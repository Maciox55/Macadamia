
  

![Macadamia Banner Image](https://github.com/Maciox55/WinPEImager/blob/master/Images/Macadamia%20Banner.png)

  

# Macadamia - Batch Automation Utility

  

Macadamia is a project which makes large batch system preparation simpler and automated. Primary purpose of the application is to allow system integrators to organize and access common system preparation scripts from a central network location. Hard drive formatting, BIOS flashing or Windows imaging; If you can do it in a Batch file, Macadamia can help you automate it.
Macadamia can execute third party applications as well, either manually or at the end of each Automation Script.


Due to Macadamia being specially developed to suit problems at my current employer, features are being implemented and extended as they are needed and are constantly iterated on. 
  

![Macadamia Demo Screenshot](https://github.com/Maciox55/Macadamia/blob/master/Images/DemoScreenshot2.png)

  

  

## How does it work?
Here is a rundown on how Macadamia works :
  

Macadamia should be used within WinPE image, before that can work, you need to make sure you import all of the packages required for WinPE to run .NET applications within WinPE, this can be done using Windows ADK and DISM. The WinPE image then can be booted up using a USB stick or PXE server.

Using ADK and DISM can take a long time to mount, modify and unmount the image each time there is a new version of Macadamia, therefore there is another way of loading Macadamia files to WinPE. 
You could set up your WinPE's `startnet.cmd` file to call `WPEINIT` to initialize the network adapter. Macadamia is meant to run on a networked environment anyway so you should have the system connected to the network already. Once the pre-installation environment is ready, you could connect to a network drive using `NET USE` with the proper paths and credentials. Once the network drive is available, you can copy the Macadamia files over the network onto WinPE X: directory, lastly starting the newly copied .exe from its directory.

Once WinPE actually copies and runs the tool, the tool will parse the `Config.xml` file for various settings, notably the Master Path. Master path contains the network location of the central directory which contains the user defined Automation Scripts and all of the required files. Master path should be organized in a particular way, although the structure is analyzed dynamically. 


### Master Folder Structure
The suggested way is for the master path to contain subfolders referencing the client's name. Within the client folder the subfolders should reference the different systems/products being made for said client, for example a part number, model number or product. Within this product folder, you should place your custom Automation Script and a folder called Required, which will hold all of the Batch scripts which will be called in this product's Automation Script as well as any other applications that are needed to actually run your Batch files.

Macadamia relies on the Required folders to make sure that the batch files can execute properly. With that said, Macadamia only copies the Required folder after the Automation Script was started. 

When writing your batch scripts you should keep in mind the location to which you will be copying the Required files.  For example if you are using diskpart and need a specific disk.txt file, you should include disk.txt in Required folder, which will be copied to X:\Required when Automation Script starts. 
`diskpart /s X:\Required\disk.txt`
In this example the batch file will look for the disk.txt in the newly created folder within X: (default WinPE directory, if yours is different you can edit Config.xml to change the directory letter).

If your batch files depends on a large file such as a WIM image file, you can reference it directly to it's location on the network, since WinPE will not allow copying of large files. For example if you want to use imagex to apply an image, you don't have to put the image in the Required folder, as it will fail to copy anyway. Here is an example:

    X:\Required\imagex.exe /apply "\\WDS-PXE-SERVER\Deployment\MASTER-IMAGES\Customer1\176\176.wim" 1 T:\
Notice how the source path is pointing to the location of a network mapped drive, only imagex.exe was copied to the Required folder. 

As a note, when one task finishes and another starts, the directory can get reset, so I suggest you CD into the proper directory before calling your command within the batch script.

### Automation Script Overview
  

The Automation Script is an XML file which contains an `IMAGE` element with a `imagePath` attribute that points to the location of the image, it can be located on the USB stick or even a network location.
The `TASKS` element should contain an **n** number of `TASK` elements. 
Each `TASK` element is a step in the Automation Script and will be executed in top-to-bottom order. 
`TASK` elements have two attributes, `type` and `command`. 
`Type` attribute refers to the type of task, there are three available values: 
 - `bat` A bat type executes a batch file from the Required folder.
 - `command` A command type executes a specific command.
 - `next` A next type starts an application automatically which can be defined in the config file.

Both `bat` and `command` types require the `command` attribute to be specified as well.
When the TASK `type` is bat, the `command` attribute should have the name of the batch file being executed. For example `<TASK type="bat" command="format.bat"/>` 
The above task is a batch task, and the file that Macadamia will call is the format.bat file. 
***NOTE: format.bat will first be copied from the Master Path, Macadamia assumes that it will be located in the Required folder next to this Automation Script.*** 

All console output will be redirected to the Macadamia console panel on the left side, if your scripts require user input, you can use the input field and the send button to send the prompt response back to the process. 
  
Macadamia may seem complicated and convoluted to set up, however it is meant to be set up only once for each type of system being produced. Once properly set up, it is easy and fast to use. Macadamia is not meant to be used with systems that might have constantly changing preparation procedures since the set up is fairly complex. 

*Note: When writing your batch files, I suggest that you write and test them on the fly on the system you intend to replicate later, that way you can be 100% sure that you can run the script successfully every time. Macadamia works with live files, meaning they can be edited, saved and reloaded without needing to restart the computer.*  
  

## Contribution
Feel free to contribute to the project, while the tool is purpose-built around my employers issues, I tried my best to make it extensible and useful for others. While I don't plan on actively developing this application past the core requirements and features, if there is any interest in developing this further I would not be opposed to continuing the work. 
