/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara Shipping Verification only
 *
 * API for evaluating transactions against direct-to-consumer Beverage Alcohol shipping regulations.  This API is currently in beta. 
 *

 * @author     Sachin Baijal <sachin.baijal@avalara.com>
 * @author     Jonathan Wenger <jonathan.wenger@avalara.com>
 * @copyright  2004-2022 Avalara, Inc.
 * @license    https://www.apache.org/licenses/LICENSE-2.0
 * @version    2.4.13
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
 */


namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// Http methods supported by swagger
    /// </summary>
    public enum HttpMethod
    {
        /// <summary>HTTP GET request.</summary>
        Get,
        /// <summary>HTTP POST request.</summary>
        Post,
        /// <summary>HTTP PUT request.</summary>
        Put,
        /// <summary>HTTP DELETE request.</summary>
        Delete,
        /// <summary>HTTP HEAD request.</summary>
        Head,
        /// <summary>HTTP OPTIONS request.</summary>
        Options,
        /// <summary>HTTP PATCH request.</summary>
        Patch
    }
}
