namespace BlazorTemplate.Identity;

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
    public Dictionary<string, string> Claims { get; set; } = [];
}


/// <summary>
/// Response for login and registration.
/// </summary>
public class AuthenticationResponse
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
