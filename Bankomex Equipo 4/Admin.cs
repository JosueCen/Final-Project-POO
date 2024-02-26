using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteDb;

namespace Bankomex_Equipo_4
{
    public class Admin
    {
        private SQLiteConn conn;

        public Admin()
        {
            conn = new SQLiteConn("Bankomex_Equipo04.db", true);
        }

        public bool ValidateClientId(int clientId, bool cond)
        {
            return conn.ValidateClientId(clientId, cond);
        }

        public bool ValidateAccountId(int accountId, bool cond)
        {
            return conn.ValidateAccountId(accountId, cond);
        }

        public bool ValidateName(string name, bool cond)
        {
            return conn.ValidateName(name, cond);
        }

        public bool ValidateUsername(string username, bool cond)
        {
            return conn.ValidateUsername(username, cond);
        }

        public List<Client> GetClientsNames(string name)
        {
            return conn.GetClientsNames(name);
        }

        public List<Client> GetClientsById(int clientId)
        {
            return conn.GetClientsById(clientId);
        }

        public List<Client> GetClientByAccountId(int clientId)
        {
            return conn.GetClientByAccountId(clientId);
        }

        public List<Client> GetClientByClientId(int clientId)
        {
            return conn.GetClientByClientId(clientId);
        }

        public List<Account> GetAccountByAccountId(int accountId)
        {
            return conn.GetAccountByAccountId(accountId);
        }

        public List<Account> GetAccountByClientId(int clientId)
        {
            return conn.GetAccountByClientId(clientId);
        }

        public List<Client> GetClientNames(string name)
        {
            return conn.GetClientNames(name);
        }

        public void AltaCliente(string username, int pin, string firstName, string lastName)
            => conn.AltaCliente(username, pin, firstName, lastName);

        public List<AccountTypes> GetAccountTypes()
        {
            return conn.GetAccountTypes();
        }

        public bool ValidateAccountType(int clientid, int accountType, bool cond)
        {
            return conn.ValidateAccountType(clientid, accountType, cond);
        }

        public void AltaCuenta(int clientid, int accountType)
            => conn.AltaCuenta(clientid, accountType);

        public List<AccountBalance> GetBalance(int accountId)
        {
            return conn.GetBalance(accountId);
        }

        public void Depósito(int accountId, int abono)
            => conn.Depósito(accountId, abono);

        public bool ValidateAhorroAccount(int accountId, bool cond)
        {
            return conn.ValidateAhorroAccount(accountId, cond);
        }

        public bool ValidateDepósito(int accountId, int abono, bool cond)
        {
            return conn.ValidateDepósito(accountId, abono, cond);
        }

        public bool ValidateRetiroAhorro(int accountId, int retiro, bool cond)
        {
            return conn.ValidateRetiroAhorro(accountId, retiro, cond);
        }

        public void Retiro(int accountId, int retiro)
            => conn.Retiro(accountId, retiro);

        public bool ValidateOverDraft(int accountId, int retiro, bool cond)
        {
            return conn.ValidateOverDraft(accountId, retiro, cond);
        }

        public bool ValidateOverDraftCondition(int accountId, bool cond)
        {
            return conn.ValidateOverDraftCondition(accountId, cond);
        }

        public void CorteAccountAhorro()
            => conn.CorteAccountAhorro();

        public void CorteMesAccountCredit()
            => conn.CorteMesAccountCredit();

        public void CorteOverDraft()
            => conn.CorteOverDraft();

        public void CorteAnualAccountCredit()
            => conn.CorteAnualAccountCredit();

        //public void CorteAnualAccountCredit2()
        //    => conn.CorteAnualAccountCredit2();
        
        //public void CorteAnualAccountCredit3()
        //    => conn.CorteAnualAccountCredit3();
        
        //public void CorteAnualAccountCredit4()
        //    => conn.CorteAnualAccountCredit4();



        public void Close()
        {
            conn.Close();
        }
    }
}
