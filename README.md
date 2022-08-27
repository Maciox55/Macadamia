
![Macadamia Banner Image](https://github.com/Maciox55/WinPEImager/blob/master/Images/Macadamia%20Banner.png)

# Macadamia - Batch Automation Utility

Macadamia is a project which hopes to make Windows imaging simple, it is a purpose built tool for my current employer.

  

I wanted to create a highly extensible way of imaging and performing tasks for the various types of computer we integrate at work, as each has a client specific custom Windows image and a set of batch scripts that run before the system is ready.

  

The tool is in really early stages of development and features are constantly being iterated on.

![Macadamia Demo Screenshot](https://github.com/Maciox55/Macadamia/blob/master/Images/DemoScreenshot.jpg)

  

## How does it work?

  
  

Here is a quick rundown on how this will work.

  

This tool is intended to be included on a custom WinPE, either by inserting it when creating the WinPE image (with all packages installed for .NET to work), or in my case, `startnet.bat` copies files from a `net use` mapped drive to the temporary X: partition created by WinPE, which then runs this tool automatically. We all know that mounting, modifying and then unmounting WinPE is really painful and takes too much time, so simply being able to copy the tool dynamically is important for rapid iteration, testing and updating. This side-load method is still being tested for limitations and feasability.

  

Once WinPE actually copies and runs the tool, the tool will look for a master path from it's config file, the path points to a central location on the network which will have various folders and subfolder along side custom `config.xml` files which contain the tasks which will be executed and additional data.

  

The XML contains an `IMAGE` element with a `imagePath` attribute that points to the location of the image. There is also a `TASKS` element which has an ***n*** number of `TASK` child elements with attribute of `command`, specifying what tasks will be executed by the tool. The command attribute can also be used to call another bat file, which should be located within the "required" folder in the same directory as the XML file.

  

`TASK` also contains a `Type` attribute which is how the tool recognizes between `bat` and `command` types. A Command type is executed within the regular process, while the Bat is executed by calling on a specific Required file which has been coped to X: directory.

  

The `TASKS` will be called one after another by calling a CMD process with the contents of the `command` parameter.

  

Here is an example of how the directory structure should look like within the Master Path provided to the config file:

* Client 1/
	* Product 1/
		* Required/
		* script.xml
* Client 2/
	* Product 1/
		* Required/
		* script.xml
	* Product 2/
		* Required/
			* biosflasher.exe
			* cleandisk.bat
		* script.xml

  

Contents of the Required folder will be copied onto the system's X: volume, which will make the files accessible for execution within the script.xml file.

  

## Project goals

  

I would like to make the tool as dynamic and extensible as possible. With that being said, there are many unknowns which still have to be tested for, before the idea can even be considered feasible.

  

I am currently thinking of ways to do dynamic string replacement, what I mean by that is the ability to insert a spectial syntax within the `command` attribute or separate .bat file which would be filled in by data passed within the `script.xml` file, which could open some doors for truly dynamic task queue. A generic .bat file could be created with the use of the special syntax, here is an example:

```bash

DISM.exe /Apply-Image /ImageFile:${imagePath} /ApplyDir:C:

```

Where `${imagePath}` will be replaced with the value of the `imagePath` attribute defined in the `script.xml` file. This same new .bat file can be then used to perform the same command on two different systems with two different images and image locations, and be even more extensible. As long as the `script.xml` contains the string literal attribute and value that is being used in a file/command, there would be no problem with replacing the literal with the value from the script.xml.

  

All of the above are just some things I have been thinking about, I don't know if I will ever get to that point.

  

## Contribution

If you somehow end up using this tool in the future, have some pointers or suggestions, feel free to create a pull request with any new features, improvements, etc. All help is welcome, I hope to build a tool that other people can find useful, not just my employer.
