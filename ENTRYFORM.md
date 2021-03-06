# Hackathon Submission Entry form

> __Important__  
> 
> Copy and paste the content of this file into README.md or face automatic __disqualification__  
> All headlines and subheadlines shall be retained if not noted otherwise.  
> Fill in text in each section as instructed and then delete the existing text, including this blockquote.

You can find a very good reference to Github flavoured markdown reference in [this cheatsheet](https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet). If you want something a bit more WYSIWYG for editing then could use [StackEdit](https://stackedit.io/app) which provides a more user friendly interface for generating the Markdown code. Those of you who are [VS Code fans](https://code.visualstudio.com/docs/languages/markdown#_markdown-preview) can edit/preview directly in that interface too.

## Team name

Sitecore Helper

## Category
Best use of SPE to help Content authors and Marketers

## Description
⟹ Write a clear description of your hackathon entry.  

  - Module Purpose
  - What problem was solved (if any)
    - How does this module solve it

_You can alternately paste a [link here](#docs) to a document within this repo containing the description._

## Video link
⟹ Provide a video highlighing your Hackathon module submission and provide a link to the video. You can use any video hosting, file share or even upload the video to this repository. _Just remember to update the link below_

⟹ [Replace this Video link](#video-link)



## Pre-requisites and Dependencies

⟹ Does your module rely on other Sitecore modules or frameworks?

- List any dependencies
- Or other modules that must be installed
- Or services that must be enabled/configured

_Remove this subsection if your entry does not have any prerequisites other than Sitecore_

## Installation instructions
⟹ Write a short clear step-wise instruction on how to install your module.  

> _A simple well-described installation process is required to win the Hackathon._  
> Feel free to use any of the following tools/formats as part of the installation:
> - Sitecore Package files
> - Docker image builds
> - Sitecore CLI
> - msbuild
> - npm / yarn
> 
> _Do not use_
> - TDS
> - Unicorn
 
f. ex. 

1. Start docker environment using `.\Start-Hackathon.ps1`
2. Open solution in Visual Studio and run build
3. Use the Sitecore Installation wizard to install the [package](#link-to-package)
4. ...
5. profit

### Configuration
No additional configuration is needed for these tools and reports to work.

## Usage instructions


After installing the package, go to Desktop mode and verify the reports were created under Reporting Tools -> PowerShell Reports -> Content Editor Tools and services

![image](https://user-images.githubusercontent.com/47169646/110219907-0f59fc00-7ee8-11eb-8382-482d6147e9e1.png)


SEO Metadata

This module gives Content editors/marketers info about metadata fields on the page. This module generates the list of pages which have Meta keywords or Meta Description  fields empty

![image](https://user-images.githubusercontent.com/47169646/110219436-3b27b280-7ee5-11eb-827d-517dfb3825dc.png)

Step 1: content authors must select a node whose child items are to be verified

![image](https://user-images.githubusercontent.com/47169646/110219450-585c8100-7ee5-11eb-826a-65c0ead5d81e.png)

Step 2: Once clicked on run button, a report is generated with the list of items which have meta data fields empty

Items with Campaigns

![image](https://user-images.githubusercontent.com/47169646/110219918-1ed94500-7ee8-11eb-89bb-4d3d4b130b0b.png)



This module can be executed against each campaign to find out any unused Campaigns
Step 1: select the Campaign and root item path

![image](https://user-images.githubusercontent.com/47169646/110219491-8b067980-7ee5-11eb-98cc-ffe5e2bd667f.png)

Step 2: click on run and then you should be able to see the list of items associated with that campaign.

![image](https://user-images.githubusercontent.com/47169646/110219500-95287800-7ee5-11eb-8767-c78e44c08921.png)


User Session Details: -

![image](https://user-images.githubusercontent.com/47169646/110219971-842d3600-7ee8-11eb-8dc0-7a057e2c686d.png)

This module can be executed to find all user details who logged into CMS.
Step 1: select the date and time filter from when you want to run the report

![image](https://user-images.githubusercontent.com/47169646/110219983-960ed900-7ee8-11eb-8ecb-9f48abcf7a86.png)

Step 2: click on run and then you should be able to see the list of users logged and there last activity time.

![image](https://user-images.githubusercontent.com/47169646/110219988-a32bc800-7ee8-11eb-9d47-08a1da4cbf58.png)

Cache Viewer: -

![image](https://user-images.githubusercontent.com/47169646/110219994-af178a00-7ee8-11eb-97c5-3beff91061b4.png)

This module can be executed to find all cache details of the website within the CMS instead of going to aspx page.

Step 1: click on run and then you should be able to see the list of all cache in the website

![image](https://user-images.githubusercontent.com/47169646/110220002-bd65a600-7ee8-11eb-93c2-5cb557253c37.png)


Selecting specific row and clicking open cache button on ribbon will open the specific cache where user can delete the cache and see details.




