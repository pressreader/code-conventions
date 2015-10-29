using System;
using System.Collections.Generic;
using System.Linq;

namespace PressReader.Naming.Sample
{
    /// <summary>
    /// Sample class.
    /// Use only to check naming conventions.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Private const.
        /// </summary>
        private const string DefaultFirstName = "Anonymus";


        /// <summary>
        /// Protected static field.
        /// </summary>
        protected static string Logger;


        /// <summary>
        /// Private static readonly field.
        /// </summary>
        private static readonly IEnumerable<string> _deniedNames = new[] { "root", "admin" };


        /// <summary>
        /// Private static field.
        /// </summary>
        private static IEnumerable<string> _excludedEmails;


        /// <summary>
        /// Protected internal field.
        /// </summary>
        protected internal string Address;


        /// <summary>
        /// Protected field.
        /// </summary>
        protected string LastName;


        /// <summary>
        /// Private readonly field.
        /// </summary>
        private readonly string _email;


        /// <summary>
        /// Private field.
        /// </summary>
        private string _firstName;


        /// <summary>
        /// Public constructor.
        /// </summary>
        public Person(string firstName, string email)
        {
            if (_excludedEmails.Contains(_email)) { }


            _firstName = firstName ?? DefaultFirstName;
            _email = email;
        }


        /// <summary>
        /// Public property.
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value?.ToLower(); }
        }


        /// <summary>
        /// Protected internal property.
        /// </summary>
        protected internal bool IsDefault => StringComparer.InvariantCultureIgnoreCase.Equals(_firstName, DefaultFirstName);


        /// <summary>
        /// Protected static property.
        /// </summary>
        protected static bool IsInitialized => _excludedEmails != null;


        /// <summary>
        /// Protected property.
        /// </summary>
        protected string FulllName => $"{_firstName} {LastName}";


        /// <summary>
        /// Protected property.
        /// </summary>
        protected virtual bool IsDenied => _deniedNames.Contains(_firstName);


        /// <summary>
        /// Public static method.
        /// </summary>
        public static void Init(IEnumerable<string> excludedEmails)
        {
            _excludedEmails = excludedEmails;
        }


        /// <summary>
        /// Public method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{_firstName}: {_email}";
        }
    }
}
