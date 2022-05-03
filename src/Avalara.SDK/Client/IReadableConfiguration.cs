/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Sachin Baijal <sachin.baijal@avalara.com>
 * @author     Jonathan Wenger <jonathan.wenger@avalara.com>
 * @copyright  2004-2022 Avalara, Inc.
 * @license    https://www.apache.org/licenses/LICENSE-2.0
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
 */


using Avalara.SDK.Auth;
using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Avalara.SDK.Client
{
    /// <summary>
    /// Represents a readable-only configuration contract.
    /// </summary>
    public interface IReadableConfiguration
    {
        /// <summary>
        /// Gets the access token.
        /// </summary>
        /// <value>Access token.</value>
        string AccessToken { get; set; }

        /// <summary>
        /// Gets the API key.
        /// </summary>
        /// <value>API key.</value>
        IDictionary<string, string> ApiKey { get; }

        /// <summary>
        /// Gets the API key prefix.
        /// </summary>
        /// <value>API key prefix.</value>
        IDictionary<string, string> ApiKeyPrefix { get; }

        /// <summary>
        /// Gets the base path.
        /// </summary>
        /// <value>Base path.</value>
        string BasePath { get; }

        /// <summary>
        /// Gets the date time format.
        /// </summary>
        /// <value>Date time format.</value>
        string DateTimeFormat { get; }

        /// <summary>
        /// Gets the default headers.
        /// </summary>
        /// <value>Default headers.</value>
        IDictionary<string, string> DefaultHeaders { get; }

        /// <summary>
        /// Gets the temp folder path.
        /// </summary>
        /// <value>Temp folder path.</value>
        string TempFolderPath { get; }

        /// <summary>
        /// Gets the HTTP connection timeout (in milliseconds)
        /// </summary>
        /// <value>HTTP connection timeout.</value>
        int Timeout { get; }

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>Username.</value>
        string Username { get; }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <value>Password.</value>
        string Password { get; }

        /// <summary>
        /// Gets the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        string GetApiKeyWithPrefix(string apiKeyIdentifier);

        /// <summary>
        /// Gets certificate collection to be sent with requests.
        /// </summary>
        /// <value>X509 Certificate collection.</value>
        X509CertificateCollection ClientCertificates { get; }
        /// <summary>
        /// Gets or sets the AvalaraEnvironment
        /// </summary>
        /// <value>AvalaraEnvironment(Enum)</value>
        AvalaraEnvironment? Environment { get; }

        /// <summary>
        /// Gets the application name.
        /// </summary>
        /// <value>AppName.</value>
        string AppName { get; }

        /// <summary>
        /// Gets the application version.
        /// </summary>
        /// <value>AppVersion.</value>
        string AppVersion { get; }
        /// <summary>
        /// Gets the machine name.
        /// </summary>
        /// <value>MachineName.</value>
        string MachineName { get; }
        
        /// <summary>
        /// Authorization Server URL for oAuth2 flow
        /// </summary>
        string AuthorizationURL { get; set; }
        /// <summary>
        /// Token Server URL for oAuth2 flow
        /// </summary>
        string TokenURL { get; set; }
        /// <summary>
        /// ClientID for oAuth2 flow
        /// </summary>
        string ClientID { get; set; }
        /// <summary>
        /// ClientSecret for oAuth2 flow
        /// </summary>
        string ClientSecret { get; set; }
        /// <summary>
        /// List of Scopes
        /// </summary>
        List<string> Scopes { get; set; }
    }
}
