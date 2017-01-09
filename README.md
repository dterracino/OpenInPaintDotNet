[AppVeyorProjectUrl]: https://ci.appveyor.com/project/GregTrevellick/openinpaintdotnet
[AppVeyorProjectBuildStatusBadgeSvg]: https://ci.appveyor.com/api/projects/status/1m2yhxf7dajm3f53?svg=true
[GitHubRepoURL]: https://github.com/GregTrevellick/OpenInPaintDotNet
[GitHubRepoIssuesURL]: https://github.com/GregTrevellick/OpenInPaintDotNet/issues
[GitHubRepoPullRequestsURL]: https://github.com/GregTrevellick/OpenInPaintDotNet/pulls
[ThirdPartyAppHomePage]: http://www.getpaint.net/
[ThirdPartyAppOfficialLogo]: http://www.getpaint.net/images/Logo4.png
[VersionNumberBadgeURL]: https://vsmarketplacebadge.apphb.com/version/GregTrevellick.OpenInPaintDotNet.svg
[VSMarketplaceUrl]: https://marketplace.visualstudio.com/items?itemName=GregTrevellick.OpeninPaintNET
[VSMarketplaceReviewsUrl]: https://marketplace.visualstudio.com/items?itemName=GregTrevellick.OpeninPaintNET#review-details

# Open In Paint.Net

[![Licence](https://img.shields.io/github/license/gittools/gitlink.svg)](/LICENSE.txt)
[![Build status][AppVeyorProjectBuildStatusBadgeSvg]][AppVeyorProjectUrl]
[![][VersionNumberBadgeURL]][VSMarketplaceUrl]

Download this extension from the [VS Marketplace][VSMarketplaceUrl].

[![](chart.png)][VSMarketplaceUrl]

---------------------------------------

<!--COPY START FOR VS GALLERY-->

A [Visual Studio](https://www.visualstudio.com/) extension to open a file in [paint.net][ThirdPartyAppHomePage] directly from within [Visual Studio](https://www.visualstudio.com/).

[![][ThirdPartyAppOfficialLogo]][ThirdPartyAppHomePage]

If you like this *free* extension, please give it a [review][VSMarketplaceReviewsUrl].

See the [change log](CHANGELOG.md) for road map and release history. Bugs can be logged [here][GitHubRepoIssuesURL].

## Who Is This Extension For ?

Whilst the Visual Studio IDE has an outstanding and feature-rich editor for a wide range of file types, even in the free "Community" editions, there may be times when you wish to open a file in a different application. Examples include application/editor familiarity, gigantic file handling, or even the desire to not override the default VS editor. 

In these scenarios, and many more, this extension may be of use to you.

Similar "Open In" VS extensions can be found [here](https://marketplace.visualstudio.com/search?term=trevellick&target=VS&sortBy=Relevance).

## Features

![](OpenInApp/Resources/ReadMeScreenShot_ContextMenu.png)

- Works with VS2012, VS2013 and VS2015.

- Open *multiple* files simultaneously with [paint.net][ThirdPartyAppHomePage] directly from within Solution Explorer.

- Warning if attempting to open a large quantity of files. The quantity is configurable in Tools | Options.

![](OpenInApp/Resources/ReadMeScreenShot_WarningLargeQuantity.png)

- Warning if attempting to open one or more file types whose extension is not typically associated with [paint.net][ThirdPartyAppHomePage]. The list of typical file extensions is configurable in Tools | Options.

![](OpenInApp/Resources/ReadMeScreenShot_WarningNonTypical.png)

- Option to supress the warning message if attempting to open a file whose extension is not typically associated with [paint.net][ThirdPartyAppHomePage].

## Options

![](OpenInApp/Resources/ReadMeScreenShot_OptionsGeneral.png)

<!--COPY END FOR VS GALLERY-->

## Contribute

Contributions to this project are welcome by raising an [Issue][GitHubRepoIssuesURL] or submitting a [Pull Request][GitHubRepoPullRequestsURL].

## License

[MIT](/LICENSE.txt)

## Legal

The [owner](https://github.com/GregTrevellick) of this [GitHub repository / software][GitHubRepoURL] is not affiliated, associated, authorized, endorsed by, employed by, sponsored by, or in any way officially connected with [paint.net][ThirdPartyAppHomePage] or any of its subsidiaries or its affiliates.

Nor has [this][GitHubRepoURL] software been authorised, approved, verified or in anyway assessed by [paint.net][ThirdPartyAppHomePage], or any of its subsidiaries or its affiliates, either as [raw source code][GitHubRepoURL] on [GitHub.com](https://github.com/) or as a [Visual Studio Extension][VSMarketplaceUrl] in the [Visual Studio Marketplace](https://marketplace.visualstudio.com/vs).

All Trademark, intellectual property rights, and other rights belonging to [paint.net][ThirdPartyAppHomePage] as described in [here][ThirdPartyAppHomePage] apply.

All [paint.net][ThirdPartyAppHomePage] logos and [paint.net][ThirdPartyAppHomePage] links belong to [paint.net][ThirdPartyAppHomePage] and their use here and any associated goodwill inures to [paint.net][ThirdPartyAppHomePage].

In no event shall [paint.net][ThirdPartyAppHomePage] be liable for any claim, damages or other liability, whether in an action of contract, tort or otherwise, arising from, out of or in connection with the software or the use or dealings in the software.

## Credits

Adapted from code originally written by [Mads Kristensen](https://github.com/madskristensen) [here](https://github.com/madskristensen/OpenInSublimeText/ "Open in Sublime Text") and [here](https://github.com/madskristensen/OpenInVsCode "Open in Visual Studio Code").

Also adapted from code originally written by [Calvin Allen](https://github.com/CalvinAllen) [here](https://github.com/CalvinAllen/OpenInNotepadPlusPlus).

Additional thanks goes to [Build 2016 Conference](https://channel9.msdn.com/Events/Build/2016/B886) and [Visual Studio Toolbox](https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/Extensions-by-Mads-Kristensen).

Thanks also to [paint.net][ThirdPartyAppHomePage] themselves.

Additional thanks to [Rei](http://forums.getpaint.net/index.php?/topic/30182-radial-fade/) for transparent [paint.net][ThirdPartyAppHomePage] logo.