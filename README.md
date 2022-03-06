# Xamarin.ZoomBinding
Zoom Mobile SDK Binding for Xamarin Android and iOS(device only)

You want to build mobile applications integrating the Zoom SDK for Android and iOS using Xamarin.

This is the binding you need. You can clone this into your project 

This project has 4 binding projects and 3 sample projects.

2 iOS Binding (MobileRTC & MobileRTCScreenShare)
2 Android Binding (CommonLib & MobileRTC)

Sample Project (Xamarin Forms with iOS and Android)

# Samples
Check the samples folder on the namespaces and how to use this binding project.

This binding is a wrapper on the obective-c and java zoom library, so documentation on the zoom forum applies

Please go through the zoom forum and documentation before raising issues.


# TODO
Sample Docs 
A Crossplatform plugin is in the works to abstract commonly used functions.

# Android Binding Tips

Sometimes resource files in the zoom sdk require editing to correct errors. A common error is that zoom will include multiple placeholders in resource strings without specifying positional syntax. For example multple instances of $s or $d or both in a single string. 

For example

 <item quantity="other">%s, %d users added this reaction</item>

 should be

<item quantity="one">%1$s, %2$d user added this reaction</item>

In cases where you need to make changes to resource files, the zoom sdk file will need to be recompiled.

Instructions for recompiling: 

1. Find mobilertc.aar or commonlib.aar
2. Change the extension to .zip
3. Unzip to a temp folder in a cmd prompt with  ```unzip mobilertc.aar -d tempFolder``` (requires unzip.exe)
4. Recompile tempFolder in a cmd prompt with the command ```jar cvf myNewLib.aar -C tempFolder/ .```  (requires jar in path variable)
5. Rename myNewLib.aar to mobilertx.aar and put it back in the Jars folder of the binding project

