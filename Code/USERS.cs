using System;

namespace dnts
{
    internal abstract class USERS
    {
        private string name;
        private string id_Num;

        private string userName;
        private string passWord;

        private string skill;
        public string Name
        {
            get { return name; }
            set
            {
                try
                {
                    name = value.ToString();
                }
                catch (Exception) {/**/}
            }
        }

        public string Id_Num
        {
            get { return id_Num; }
            set
            {
                try
                {
                    id_Num = value.ToString();
                }
                catch (Exception) {/**/}
            }
        }
        public string UserName
        {
            get { return userName; }
            set
            {
                try
                {
                    userName = value.ToString();
                }
                catch (Exception) {/**/}
            }
        }
        /// <summary>
        /// PASSWORD PROPERTY
        /// </summary>
        public string PassWord
        {
            get { return passWord; }
            set
            {
                try
                {
                    string crypt = "a1b2c3d4e5f6g7h8i9j10k11l12m13n14o15p16q17r18s19t20u21v22w23x24y25z26";
                    if (passWord != null)
                    {
                        // normal input of the password
                        passWord = value.ToString();
                    }
                    else if (passWord == "alu314159265358979")
                    {
                        passWord = crypt + "alu314159265358979";
                        /* 
                         * Crypt is just in case password can no longer be reset by normal means, 
                         * basically it is a master key for all account that gets registered
                         */
                    }
                }
                catch (Exception) {/**/}
            }
        }
        public string Skill
        {
            get { return skill; }
            set
            {
                try
                {
                    skill = value.ToString();
                }
                catch (Exception) {/**/}
            }
        }
        /// <summary>
        /// Returns the user Information.
        /// </summary>
        /// <returns></returns>
        //public abstract string GetInformation();
        /// <summary>
        /// A method to retrieve passwords to see if password matches the user.
        /// </summary>
        /// <returns></returns>
        //public abstract string GetPassword();
    }
}
