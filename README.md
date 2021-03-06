![Hackathon Logo](docs/images/hackathon.png?raw=true "Hackathon Logo")
# Sitecore Hackathon 2021

- MUST READ: **[Submission requirements](SUBMISSION_REQUIREMENTS.md)**
- [Entry form template](ENTRYFORM.md)
- [Starter kit instructions](STARTERKIT_INSTRUCTIONS.md)
  

# Hackathon Submission Entry form

You can find a very good reference to Github flavoured markdown reference in [this cheatsheet](https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet). If you want something a bit more WYSIWYG for editing then could use [StackEdit](https://stackedit.io/app) which provides a more user friendly interface for generating the Markdown code. Those of you who are [VS Code fans](https://code.visualstudio.com/docs/languages/markdown#_markdown-preview) can edit/preview directly in that interface too.

## Team name

Sitecore Helper

**Category:** Best use of SPE to help Content authors and Marketers

## Description
⟹ Our module includes reports developed in SPE to help Content Authors and Marketers get information about the content they are working on. The following is a list of the tools and reports included in this package:

 1.SEO Metadata
 
 2.Items with Campaigns

 3.User Session Details
 
 4.Cache Viewer
 
5. Page and data items keyword Report
 
6. User Item Updates Report


## Video link

⟹ [https://www.youtube.com/watch?v=iSecRkGTEk8](#video-link)


## Pre-requisites and Dependencies

- Sitecore 10.1
- Sitecore SPE

_Remove this subsection if your entry does not have any prerequisites other than Sitecore_

## Installation instructions
-	Download the package from packages folder (https://github.com/Sitecore-Hackathon/2021-Sitecore-Helper/blob/develop/Packages)
-	Go to Development Tools -> Installation Wizard.
-	Upload the .zip package. 
-	Click on Install and wait for the installation process to finish.
-	Make sure you restart the Sitecore client after installation is finished.

### Configuration
No additional configuration is needed for these tools and reports to work.

## Usage instructions

After installing the package, go to Desktop mode and verify the reports were created under Reporting Tools -> PowerShell Reports -> Content Editor Tools and services

![image](https://user-images.githubusercontent.com/47169646/110219907-0f59fc00-7ee8-11eb-8382-482d6147e9e1.png)


## SEO Metadata

This module gives Content editors/marketers info about metadata fields on the page. This module generates the list of pages which have Meta keywords or Meta Description  fields empty

![image](https://user-images.githubusercontent.com/47169646/110219436-3b27b280-7ee5-11eb-827d-517dfb3825dc.png)

Step 1: content authors must select a node whose child items are to be verified

![image](https://user-images.githubusercontent.com/47169646/110219450-585c8100-7ee5-11eb-826a-65c0ead5d81e.png)

Step 2: Once clicked on run button, a report is generated with the list of items which have meta data fields empty

## Items with Campaigns

![image](https://user-images.githubusercontent.com/47169646/110219918-1ed94500-7ee8-11eb-89bb-4d3d4b130b0b.png)


This module can be executed against each campaign to find out any unused Campaigns
Step 1: select the Campaign and root item path

![image](https://user-images.githubusercontent.com/47169646/110219491-8b067980-7ee5-11eb-98cc-ffe5e2bd667f.png)

Step 2: click on run and then you should be able to see the list of items associated with that campaign.

![image](https://user-images.githubusercontent.com/47169646/110219500-95287800-7ee5-11eb-8767-c78e44c08921.png)


## User Session Details: -

![image](https://user-images.githubusercontent.com/47169646/110219971-842d3600-7ee8-11eb-8dc0-7a057e2c686d.png)

This module can be executed to find all user details who logged into CMS.
Step 1: select the date and time filter from when you want to run the report

![image](https://user-images.githubusercontent.com/47169646/110219983-960ed900-7ee8-11eb-8ecb-9f48abcf7a86.png)

Step 2: click on run and then you should be able to see the list of users logged and there last activity time.

![image](https://user-images.githubusercontent.com/47169646/110219988-a32bc800-7ee8-11eb-9d47-08a1da4cbf58.png)

## Cache Viewer: -

![image](https://user-images.githubusercontent.com/47169646/110219994-af178a00-7ee8-11eb-97c5-3beff91061b4.png)

This module can be executed to find all cache details of the website within the CMS instead of going to aspx page.

Step 1: click on run and then you should be able to see the list of all cache in the website

![image](https://user-images.githubusercontent.com/47169646/110220002-bd65a600-7ee8-11eb-93c2-5cb557253c37.png)


Selecting specific row and clicking open cache button on ribbon will open the specific cache where user can delete the cache and see details.





