using System;
using Sitecore;
using Sitecore.Diagnostics;
using Sitecore.Shell.Framework;
using Sitecore.Shell.Framework.Commands;
using Sitecore.Text;

namespace Security.Rights.Reporting.Shell
{
    /// <summary>
    /// Represents the User Manager command.
    /// 
    /// </summary>
    [Serializable]
    public class OpenUserinfo : Command
    {
        /// <summary>
        /// Executes the command in the specified context.
        /// 
        /// </summary>
        /// <param name="context">The context.</param>
        public override void Execute(CommandContext context)
        {
            Assert.ArgumentNotNull((object)context, "context");
            UrlString urlString = new UrlString();
            Windows.RunApplication("Security Reporting", urlString.ToString());
        }

        /// <summary>
        /// Queries the state of the command.
        /// 
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>
        /// The state of the command.
        /// </returns>
        public override CommandState QueryState(CommandContext context)
        {
            Assert.ArgumentNotNull((object)context, "context");
            if (!this.IsAdvancedClient() || Context.Database.GetItem("/sitecore/content/Applications/Security Reporting") == null)
                return CommandState.Hidden;
            else
                return base.QueryState(context);
        }
    }
}
