using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTemplate.Dto
{
    public class AccountEmail
    {
        public string Email { get; set; }
    }

    public class IdentityManageUserResponse
    {
        public string Email { get; set; }
        public bool IsEmailConfirmed { get; set; }
    }

    public class IdentityManage2faResponse
    {
        public string SharedKey { get; set; }
        public int RecoveryCodesLeft { get; set; }
        public string[] RecoveryCodes { get; set; }
        public bool IsTwoFactorEnabled { get; set; }
        public bool IsMachineRemembered { get; set; }
    }

    public class LoginResponse
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public int Status { get; set; }
    }

    public class User 
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public bool IsAdministrator { get; set; }
        public bool IsSelf { get; set; }
    }

    /// <summary>
    /// Response for login and registration.
    /// </summary>
    public class FormResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether the action was successful.
        /// </summary>
        public bool Succeeded { get; set; }

        /// <summary>
        /// On failure, the problem details are parsed and returned in this array.
        /// </summary>
        public List<string> ErrorList { get; set; } = new List<string>();

        public bool Prompt2FA { get; set; }
    }

    /// <summary>
    /// Basic user information to register and/or login.
    /// </summary>
    public class UserBasic
    {
        /// <summary>
        /// The email address.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// The password.
        /// </summary>
        public string Password { get; set; } = string.Empty;
    }

    /// <summary>
    /// User info from identity endpoint to establish claims.
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// The email address.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// A value indicating whether the email has been confirmed yet.
        /// </summary>
        public bool IsEmailConfirmed { get; set; }

        /// <summary>
        /// The list of claims for the user.
        /// </summary>
        public Dictionary<string, string> Claims { get; set; }
         = [];
    }
}



