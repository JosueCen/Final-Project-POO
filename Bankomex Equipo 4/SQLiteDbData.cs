using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteDb
{
    public class Client
    {
        public int Id { get; }
        public string ClientFullname { get; }

        public Client(int id, string clientFullname)
        {
            Id = id;
            ClientFullname = clientFullname;
        }
    }

    public class Account
    {
        public int Id { get; }
        public string AccountType { get; }

        public Account(int id, string accountType)
        {
            Id = id;
            AccountType = accountType;
        }
    }

    public class FullClient
    {
        public int Id { get; }
        public string Username { get; }
        public int Pin { get; }
        public  string FirstName { get; }
        public string LastName { get; }

        public FullClient(int id, string username, int pin, string firstName, string lastName)
        {
            Id = id;
            Username = username;
            Pin = pin;
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class AccountTypes
    {
        public int Id { get; }
        public string AccountType { get; }

        public AccountTypes(int id, string accountType)
        {
            Id = id;
            AccountType = accountType;
        }
    }

    public class AccountBalance
    {
        public int Id { get; }
        public int Balance { get; }

        public AccountBalance(int id, int balance)
        {
            Id = id;
            Balance = balance;
        }
    }

    public class MaxCreditAccount
    {
        public int Balance { get; }
        public int MaxCredit { get; }

        public MaxCreditAccount(int balance, int maxCredit)
        {
            Balance = balance;
            MaxCredit = maxCredit;
        }
    }

    public class OverDraftCondition
    {
        public string Limited { get; }

        public OverDraftCondition(string limited)
        {
            Limited = limited;
        }
    }

    public partial class SQLiteConn
    {
        public bool ValidateClientId(int clientId, bool cond)
        {
            List<Client> idClients = new List<Client>();

            string sql = "SELECT ID, last_name ||', '|| first_name AS Client FROM clients";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    idClients.Add(new Client(rs.GetInt32("ID"), rs.GetString("Client")));
                }
            }

            for (int i = 0; i < idClients.Count; ++i)
            {
                if (idClients[i].Id == clientId)
                {
                    cond = true;
                }
            }

            return cond;
        }

        public bool ValidateAccountId(int accountId, bool cond)
        {
            List<Account> accountidaccount = new List<Account>();

            string sql = "SELECT a.id AS IdCuenta, at.name AS Tipo_de_cuenta"
                         + " FROM accounts a"
                         + " INNER JOIN clients c ON a.client_id = c.id"
                         + " INNER JOIN 'account-types' at ON a.account_type = at.id"
                         + $" WHERE a.id = {accountId} ";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    accountidaccount.Add(new Account(rs.GetInt32("IdCuenta"), rs.GetString("Tipo_de_cuenta")));
                }
            }

            for (int i = 0; i < accountidaccount.Count; ++i)
            {
                if (accountidaccount[i].Id == accountId)
                {
                    cond = true;
                }
            }

            return cond;
        }

        public bool ValidateName(string name, bool cond)
        {
            List<Client> clientNames = new List<Client>();

            string sql = "SELECT ID, last_name ||', '|| first_name AS Client FROM clients"
                         + $" WHERE last_name LIKE '%{name}%' OR first_name LIKE '%{name}%'"
                         + $" ORDER BY id";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    clientNames.Add(new Client(rs.GetInt32("ID"), rs.GetString("Client")));
                }
            }

            if (clientNames.Count == 0)
            {
                cond = false;
            }

            return cond;
        }

        public bool ValidateUsername(string username, bool cond)
        {
            List<FullClient> clientUsernames = new List<FullClient>();

            string sql = "SELECT ID, username, pin, last_name, first_name FROM clients"
                         + $" WHERE username LIKE '%{username}%'";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    clientUsernames.Add(new FullClient(rs.GetInt32("ID"), rs.GetString("username"), rs.GetInt32("pin"), 
                                                   rs.GetString("first_name"), rs.GetString("last_name")));
                }
            }

            if (clientUsernames.Count == 0)
            {
                cond = true;
            }

            return cond;
        }

        public List<Client> GetClientsNames(string name)
        {
            List<Client> clientByNames = new List<Client>();

            string sql = "SELECT ID, last_name ||', '|| first_name AS Client FROM clients"
                         + $" WHERE last_name LIKE '%{name}%' OR first_name LIKE '%{name}%'"
                         + $" ORDER BY id";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    clientByNames.Add(new Client(rs.GetInt32("ID"), rs.GetString("Client")));
                }
            }

            return clientByNames;
        }

        public List<Client> GetClientsById(int clientId)
        {
            List<Client> clientsbyid = new List<Client>();

            string sql = $"SELECT ID, last_name ||', '|| first_name AS Client FROM clients WHERE id = {clientId}";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    clientsbyid.Add(new Client(rs.GetInt32("ID"), rs.GetString("Client")));
                }
            }

            return clientsbyid;
        }        

        public List<Client> GetClientByAccountId(int accountId)
        {
            List<Client> clientsbyaccountid = new List<Client>();

            string sql = "SELECT c.id AS ID, c.last_name || ', ' || c.first_name AS Cliente"
                         + " FROM accounts a"
                         + " INNER JOIN clients c ON a.client_id = c.id"
                         + " INNER JOIN 'account-types' at ON a.account_type = at.id"
                         + $" WHERE a.id = {accountId} ";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    clientsbyaccountid.Add(new Client(rs.GetInt32("ID"), rs.GetString("Cliente")));
                }
            }

            return clientsbyaccountid;
        }

        public List<Client> GetClientByClientId(int clientId)
        {
            List<Client> clientbyclientid = new List<Client>();

            string sql = "SELECT DISTINCT c.id AS ID, c.last_name || ', ' || c.first_name AS Cliente"
                         + " FROM accounts a"
                         + " INNER JOIN clients c ON a.client_id = c.id"
                         + " INNER JOIN 'account-types' ON a.account_type = 'account-types'.id"
                         + $" WHERE c.id = {clientId}";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    clientbyclientid.Add(new Client(rs.GetInt32("ID"), rs.GetString("Cliente")));
                }
            }

            return clientbyclientid;
        }

        public List<Account> GetAccountByAccountId(int accountId)
        {
            List<Account> accountsbyaccountid = new List<Account>();

            string sql = "SELECT a.id AS IdCuenta, at.name AS Tipo_de_cuenta"
                         + " FROM accounts a"
                         + " INNER JOIN clients c ON a.client_id = c.id"
                         + " INNER JOIN 'account-types' at ON a.account_type = at.id"
                         + $" WHERE a.id = {accountId} ";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    accountsbyaccountid.Add(new Account(rs.GetInt32("IdCuenta"), rs.GetString("Tipo_de_cuenta")));
                }
            }

            return accountsbyaccountid;
        }       

        public List<Account> GetAccountByClientId(int clientId)
        {
            List<Account> accountsbyclientid = new List<Account>();

            string sql = "SELECT a.id AS IdCuenta, at.name AS Tipo_de_cuenta"
                         + " FROM accounts a"
                         + " INNER JOIN clients c ON a.client_id = c.id"
                         + " INNER JOIN 'account-types' at ON a.account_type = at.id"
                         + $" WHERE a.client_id = {clientId} ";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    accountsbyclientid.Add(new Account(rs.GetInt32("IdCuenta"), rs.GetString("Tipo_de_cuenta")));
                }
            }

            return accountsbyclientid;
        }

        public List<Client> GetClientNames(string name)
        {
            List<Client> clientsByName = new List<Client>();

            string sql = "SELECT DISTINCT c.id AS Client_Id, c.last_name || ', ' || c.first_name AS Client"
                         + " FROM accounts a"
                         + " INNER JOIN clients c ON a.client_id = c.id"
                         + " INNER JOIN 'account-types' ON a.account_type = 'account-types'.id"
                         + $" WHERE c.last_name LIKE '%{name}%' OR c.first_name LIKE '%{name}%'";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    clientsByName.Add(new Client(rs.GetInt32("Client_Id"), rs.GetString("Client")));
                }
            }

            return clientsByName;
        }

        public void AltaCliente(string username, int pin, string firstName, string lastName)
        {
            string sql = "INSERT INTO clients(id, username, pin, first_name, last_name)"
                         + $" VALUES((SELECT max(id) + 1 AS ID FROM clients), '{username}', {pin}, '{firstName}', '{lastName}')";

            ExecuteNonQuery(sql);
        }

        public List<AccountTypes> GetAccountTypes()
        {
            List<AccountTypes> accountTypes = new List<AccountTypes>();

            string sql = "SELECT ID, name FROM 'account-types'";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    accountTypes.Add(new AccountTypes(rs.GetInt32("ID"), rs.GetString("name")));
                }
            }

            return accountTypes;
        }

        public bool ValidateAccountType(int clientid, int accountType, bool cond)
        {
            List<AccountTypes> accountTypesByClient = new List<AccountTypes>();

            string sql = "SELECT at.id, at.name"
                         + " FROM accounts a"
                         + " INNER JOIN 'account-types' at on at.id = a.account_type"
                         + $" WHERE client_id = {clientid} AND account_type = {accountType}";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    accountTypesByClient.Add(new AccountTypes(rs.GetInt32("ID"), rs.GetString("name")));
                }
            }

            if (accountTypesByClient.Count == 0)
            {
                cond = true;
            }

            return cond;
        }

        public void AltaCuenta(int clientid, int accountType)
        {
            string sql = "INSERT INTO accounts (id, client_id, account_type, balance)"
                         + $" VALUES ((SELECT max(id)+1 AS id FROM accounts), {clientid}, {accountType}, 0)";

            ExecuteNonQuery(sql);
        }

        public List<AccountBalance> GetBalance(int accountId)
        {
            List<AccountBalance> accountTypes = new List<AccountBalance>();

            string sql = $"SELECT id, balance FROM accounts WHERE id = {accountId}";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    accountTypes.Add(new AccountBalance(rs.GetInt32("id"), rs.GetInt32("balance")));
                }
            }

            return accountTypes;
        }

        public bool ValidateAhorroAccount(int accountId, bool cond)
        {
            List<AccountTypes> accountType = new List<AccountTypes>();

            string sql = "SELECT a.account_type AS ID, at.name AS name"
                            + " FROM accounts a"
                            + " inner join 'account-types' at on at.id = a.account_type"
                            + $" WHERE a.id = {accountId}";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    accountType.Add(new AccountTypes(rs.GetInt32("ID"), rs.GetString("name")));
                }
            }

            if (accountType[0].Id == 0)
            {
                cond = true;
            }

            return cond;
        }

        public bool ValidateDepósito(int accountId, int abono, bool cond)
        {
            List<AccountBalance> balance = new List<AccountBalance>();

            string sql = $"SELECT id, balance FROM accounts WHERE id = {accountId}";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    balance.Add(new AccountBalance(rs.GetInt32("id"), rs.GetInt32("balance")));
                }
            }

            if (abono <= balance[0].Balance)
            {
                cond = true;
            }

            return cond;
        }

        public void Depósito(int accountId, int abono)
        {
            string sql = $"UPDATE accounts SET balance = balance + {abono} WHERE id = {accountId}";

            ExecuteNonQuery(sql);
        }

        public bool ValidateRetiroAhorro(int accountId, int retiro, bool cond)
        {
            List<AccountBalance> balance = new List<AccountBalance>();

            string sql = $"SELECT id, balance FROM accounts WHERE id = {accountId}";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    balance.Add(new AccountBalance(rs.GetInt32("id"), rs.GetInt32("balance")));
                }
            }

            if (retiro <= balance[0].Balance)
            {
                cond = true;
            }

            return cond;
        }

        public void Retiro(int accountId, int retiro)
        {
            string sql = $"UPDATE accounts SET balance = balance - {retiro} WHERE id = {accountId}";

            ExecuteNonQuery(sql);
        }

        public bool ValidateOverDraft(int accountId, int retiro, bool cond)
        {
            List<MaxCreditAccount> maxCredits = new List<MaxCreditAccount>();

            string sql = $"SELECT a.balance AS balance, ap.max_credit AS maxcredit"
                            + " FROM accounts a"
                            + " INNER JOIN 'account-types' ap ON a.account_type = ap.id"
                            + $" WHERE a.id = {accountId}";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    maxCredits.Add(new MaxCreditAccount(rs.GetInt32("balance"), rs.GetInt32("maxcredit")));
                }
            }

            if ((retiro + maxCredits[0].Balance) > maxCredits[0].MaxCredit)
            {
                cond = true;
            }

            return cond;
        }

        public bool ValidateOverDraftCondition(int accountId, bool cond)
        {
            List<OverDraftCondition> overDrafts = new List<OverDraftCondition>();

            string sql = $"SELECT ap.limited AS limited"
                            + " FROM accounts a"
                            + " INNER JOIN 'account-types' ap ON a.account_type = ap.id"
                            + $" WHERE a.id = {accountId}";
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    overDrafts.Add(new OverDraftCondition(rs.GetString("limited")));
                }
            }

            cond = Convert.ToBoolean(overDrafts[0].Limited);

            return cond;
        }

        public void CorteAccountAhorro()
        {
            string sql = $"UPDATE accounts"
                            + " SET balance = balance + (SELECT monthly_fee"
                            + "                          FROM 'account-types'"
                            + "                          WHERE id = 0)"
                            + " WHERE account_type = 0";

            ExecuteNonQuery(sql);
        }

        public void CorteMesAccountCredit()
        {
            string cargomes1 = "UPDATE accounts"
                             + " SET balance = balance + ((balance * (SELECT interest_pct"
                             + "                            FROM 'account-types'"
                             + "                            WHERE id = 1))/ 100)"
                             + " WHERE account_type = 1";

            string cargomes2 = "UPDATE accounts"
                             + " SET balance = balance + ((balance * (SELECT interest_pct"
                             + "                            FROM 'account-types'"
                             + "                            WHERE id = 2))/ 100)"
                             + " WHERE account_type = 2";

            string cargomes3 = "UPDATE accounts"
                             + " SET balance = balance + ((balance * (SELECT interest_pct"
                             + "                            FROM 'account-types'"
                             + "                            WHERE id = 3))/ 100)"
                             + " WHERE account_type = 3";

            string cargomes4 = "UPDATE accounts"
                             + " SET balance = balance + ((balance * (SELECT interest_pct"
                             + "                            FROM 'account-types'"
                             + "                            WHERE id = 4))/ 100)"
                             + " WHERE account_type = 4";

            ExecuteNonQuery(cargomes1);
            ExecuteNonQuery(cargomes2);
            ExecuteNonQuery(cargomes3);
            ExecuteNonQuery(cargomes4);
        }

        public void CorteOverDraft()
        {
            string overdraft1 = "UPDATE accounts"
                                + " SET balance = balance + (SELECT overdraft_fee"
                                + "                          FROM 'account-types'"
                                + "                          WHERE id = 1)"
                                + " WHERE account_type = 1 AND balance > (SELECT max_credit"
                                + "                                       FROM 'account-types'"
                                + "                                       WHERE id = 1)";

            string overdraft2 = "UPDATE accounts"
                                + " SET balance = balance + (SELECT overdraft_fee"
                                + "                          FROM 'account-types'"
                                + "                          WHERE id = 2)"
                                + " WHERE account_type = 2 AND balance > (SELECT max_credit"
                                + "                                       FROM 'account-types'"
                                + "                                       WHERE id = 2)";

            string overdraft3 = "UPDATE accounts"
                                + " SET balance = balance + (SELECT overdraft_fee"
                                + "                          FROM 'account-types'"
                                + "                          WHERE id = 3)"
                                + " WHERE account_type = 3 AND balance > (SELECT max_credit"
                                + "                                       FROM 'account-types'"
                                + "                                       WHERE id = 3)";

            string overdraft4 = "UPDATE accounts"
                                + " SET balance = balance + (SELECT overdraft_fee"
                                + "                          FROM 'account-types'"
                                + "                          WHERE id = 4)"
                                + " WHERE account_type = 4 AND balance > (SELECT max_credit"
                                + "                                       FROM 'account-types'"
                                + "                                       WHERE id = 4)";

            ExecuteNonQuery(overdraft1);
            ExecuteNonQuery(overdraft2);
            ExecuteNonQuery(overdraft3);
            ExecuteNonQuery(overdraft4);
        }

        public void CorteAnualAccountCredit()
        {
            string cargoanual1 = "UPDATE accounts"
                             + " SET balance = balance + ((balance * (SELECT interest_pct"
                             + "                            FROM 'account-types'"
                             + "                            WHERE id = 1))/ 100) + (SELECT annual_fee FROM 'account-types' WHERE id = 1)"
                             + " WHERE account_type = 1";

            string cargoanual2 = "UPDATE accounts"
                             + " SET balance = balance + ((balance * (SELECT interest_pct"
                             + "                            FROM 'account-types'"
                             + "                            WHERE id = 2))/ 100) + (SELECT annual_fee FROM 'account-types' WHERE id = 2)"
                             + " WHERE account_type = 2";

            string cargoanual3 = "UPDATE accounts"
                             + " SET balance = balance + ((balance * (SELECT interest_pct"
                             + "                            FROM 'account-types'"
                             + "                            WHERE id = 3))/ 100) + (SELECT annual_fee FROM 'account-types' WHERE id = 3)"
                             + " WHERE account_type = 3";

            string cargoanual4 = "UPDATE accounts"
                             + " SET balance = balance + ((balance * (SELECT interest_pct"
                             + "                            FROM 'account-types'"
                             + "                            WHERE id = 4))/ 100) + (SELECT annual_fee FROM 'account-types' WHERE id = 4)"
                             + " WHERE account_type = 4";

            ExecuteNonQuery(cargoanual1);
            ExecuteNonQuery(cargoanual2);
            ExecuteNonQuery(cargoanual3);
            ExecuteNonQuery(cargoanual4);
        }
    }
}
