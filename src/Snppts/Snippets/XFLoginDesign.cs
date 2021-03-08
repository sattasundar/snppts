using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class XFLoginDesign : IAmASnippet
    {
        public string Slug => "xamarin-forms-login-ui";
        public string Title => "XFModernLogin-UI";
        public string Description => "This modern login ui is designed by Karan Sisodiya.";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("sattasundar/XFModernLogin-UI");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new SattaSundar();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://github.com/sattasundar/XFModernLogin-UI/blob/main/images/ios-getstarted.png"),
            new Uri("https://github.com/sattasundar/XFModernLogin-UI/blob/main/images/ios-login.png"),
            new Uri("https://github.com/sattasundar/XFModernLogin-UI/blob/main/images/ios-register.png"),
            new Uri("https://github.com/sattasundar/XFModernLogin-UI/blob/main/images/android-getstarted.png"),
            new Uri("https://github.com/sattasundar/XFModernLogin-UI/blob/main/images/android-login.png"),
            new Uri("https://github.com/sattasundar/XFModernLogin-UI/blob/main/images/android-register.png")
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.Shapes,
            Category.XamarinCommunityToolkit, 
        };
    }
}
