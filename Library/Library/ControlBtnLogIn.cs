namespace Library
{
    public class ControlBtnLogIn
    {
        private FrmVerification verification;
        public ControlBtnLogIn(FrmVerification verification)
        {
            this.verification = verification;
            verification.GetContorolBtnLogIn(this);
        }
        public bool CheckPassword(string password)
        {
            if (password.Length > 4 && password != "Password")
                return true;
            return false;
        }

        public bool CheckLogin(string login)
        {
            if (login.Length > 4 && login != "Gmail")
                return true;
            return false;
        }

        public void EnableFalse()
        {
            verification.panelSignIn.Enabled = false;
            verification.lblSignIn.Enabled = false;
        }

        public void EnableTrue()
        {
            verification.panelSignIn.Enabled = true;
            verification.lblSignIn.Enabled = true;
        }
    }
}
