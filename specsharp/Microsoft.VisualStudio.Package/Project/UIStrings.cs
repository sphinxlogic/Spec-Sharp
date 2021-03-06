//-----------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All Rights Reserved.
//
//-----------------------------------------------------------------------------
using System;
using System.Resources;
using System.Globalization;

namespace Microsoft.VisualStudio.Package{ 

  public enum UIStringNames {
    DebugCaption, // Debugging
    BuildCaption, // Build
    GeneralCaption, // General
    Application, // Application
    Project , // Project 
    WrapperAssembly, // Wrapper Assembly for ActiveX/COM Objects
    CodeGeneration, // Code Generation
    ErrorsAndWarnings, // Errors and Warnings
    Outputs, // Outputs
    StartAction, // Start Action
    StartOptions, // Start Options
    Advanced, // Advanced
    Misc, // Misc
    Specialized,
    AssemblyName, // Assembly Name
    AssemblyNameDescription, // The name of the output file that will hold assembly metadata.
    OutputType, // Output Type
    OutputTypeDescription, // The type of application to build.
    DefaultNamespace, // Default Namespace
    DefaultNamespaceDescription, // Specifies the default namespace for added items, such as classes, that are added via the Add New Item Dialog Box.
    StartupObject, // Startup Object
    StartupObjectDescription, // The name of the class that contains the static Main method that you want called when you launch your application.
    ApplicationIcon, // Application Icon
    ApplicationIconDescription, // Sets the .ico file to use as your application icon.
    ProjectFile, // Project File
    ProjectFileDescription, // The name of the file containing build, configuration, and other information about the project.
    ProjectFolder, // Project Folder
    ProjectFolderDescription, // The absolute location of the project.
    OutputFile, // Output File
    OutputFileDescription, // The name of the project's primary output file.
    WrapperAssemblyKeyFile, // Wrapper Assembly Key File
    WrapperAssemblyKeyFileDescription, // Specifies the key file to use for ActiveX/COM object wrappers.
    WrapperAssemblyKeyName, // Wrapper Assembly Key Name
    WrapperAssemblyKeyNameDescription, // Specifies the Wrapper Assembly Key Name for ActiveX/COM objects.
    DefineConstants, // Define Constants
    DefineConstantsDescription, // Specify symbols on which to perform conditional compilation.
    OptimizeCode, // Optimize Code
    OptimizeCodeDescription, // Enables or disables optimizations performed by the compiler to make your output file smaller, faster and more efficient.
    CheckArithmeticOverflow, // Check Arithmetic Overflow
    CheckArithmeticOverflowDescription, // Check all integer arithmetic for out of bounds results.
    AllowUnsafeCode, // Allow Unsafe Code
    AllowUnsafeCodeDescription, // Enable use of the unsafe keyword.
    WarningLevel, // Warning Level
    WarningLevelDescription, // Specify the level of detail for compiler warnings.
    TreatWarningsAsErrors, // Treat Warnings As Errors
    TreatWarningsAsErrorsDescription, // Indicates whether to treat all compiler warnings as errors.
    OutputPath, // Output Path
    OutputPathDescription, // Specifies the location of the output files for this project's configuration.
    XMLDocumentationFile, // XML Documentation File
    XMLDocumentationFileDescription, // Specifies the name of the file that is to contain the XML documentation generated by the compiler.
    GenerateDebuggingInformation, // Generate Debugging Information
    GenerateDebuggingInformationDescription, // Specifies whether to generate debugging information.
    RegisterForCOMInterop, // Register For COM Interop
    RegisterForCOMInteropDescription, // Register the project's output file for use with COM components.  The output file must contain assembly metadata with a strong name.
    DebugMode, // Debug Mode
    DebugModeDescription, // Determins whether an appliation, a URL, or the project output will be launched when you start debugging.
    StartApplication, // Start Application
    StartApplicationDescription, // Indicates the program that should be started when the project is debugged. 
    StartURL, // Start URL
    StartURLDescription, // Indicates the URL that should be launched when the application is debugged.
    StartPage, // Start Page
    StartPageDescription, // Specifies the page that will launch within the browser when you begin debugging a web project or URL.  
    CommandLineArguments, // Command Line Arguments
    CommandLineArgumentsDescription, // Indicates command line arguments to be passed to the program on startup.
    WorkingDirectory, // Working Directory
    WorkingDirectoryDescription, // Indicates the working directory from which the project or custom application is launched.
    UseInternetExplorer, // Use Internet Explorer
    UseInternetExplorerDescription, // Indicates that Internet Explorer should be used to start the project during debugging.
    EnableRemoteDebugging, // Enable Remote Debugging
    EnableRemoteDebuggingDescription, // Enable debugging of the project from a remote machine.
    RemoteDebugMachine, // Remote Debug Machine
    RemoteDebugMachineDescription, // Name of the machine to be used for remote debugging.
    IncrementalBuild, // Incremental Build
    IncrementalBuildDescription, // Enable the incremental compiler.
    BaseAddress, // Base Address
    BaseAddressDescription, // Specify the preferred address at which to load a .dll at run time.
    BuildAction, // Build Action
    BuildActionDescription, // How the file relates to the build and deployment process
    CustomTool, // Custom Tool
    CustomToolDescription, // Specifies a tool that transforms the file at design time and generating another file that is then included in the build
    CustomToolNamespace, // Custom Tool Namespace
    CustomToolNamespaceDescription, // The namespace into which the output of the custom tool is placed
    FileName, // File Name
    FileNameDescription, // The name of the file or folder
    FullPath, // Full Path
    FullPathDescription, // FullPath of the file
    FileAlignment, // File Alignment
    FileAlignmentDescription, // This advanced property is used for optimizing memory access.
    v1, // Microsoft .Net Framework v1
    v11, // Microsoft .Net Framework v1.1
    v12, // Microsoft .Net Framework v1.2
    v2, // Microsoft .Net Framework v2
    cli1, // ECMA-335 CLI compatible framework (location must be provided)
    Exe, // Console Application
    Library, // Class Library
    WinExe, // Windows Application
    Compile, // Compile
    Content, // Content
    EmbeddedResource, // Embedded Resource
    None, // None
    NoStandardLibraries,
    NoStandardLibrariesDescription,
    Program, // Program
    URL, // URL
    MaxErrorsReached, // sorry, maximal number of error messages reached
    BraceMatchStatus, // Matches: {0}
    ShadowedAssembly,
    ShadowedAssemblyDescription,
    StandardLibraryLocation,
    StandardLibraryLocationDescription,
    TargetPlatform, // Target Platform
    TargetPlatformDescription, // The version of the Common Language Runtime to use for output assembly
    TargetPlatformLocation, // Target Platform FullPath
    TargetPlatformLocationDescription, // The location of the target platform
    Error, // Error
    Warning, // Warning
    ErrorSaving, // Error Saving (message box caption)
    SaveModifiedDocuments,
    SaveCaption,
    FileAlreadyInProject,
    FileAlreadyInProjectCaption,
    FileAlreadyExists,
    FileAlreadyExistsCaption,
    FileProperties,
    ProjectProperties,
    FolderProperties,
    ReferenceProperties,
    FolderName,
    FolderNameDescription,
    RefName,
    RefNameDescription,
    CopyToLocal,
    CopyToLocalDescription,
    RunTimeChecks,
    DisableAssumeChecks,
    DisableAssumeChecksDescription,
    DisableDefensiveChecks,
    DisableDefensiveChecksDescription,
    DisableGuardedClassesChecks,
    DisableGuardedClassesChecksDescription,
    DisableInternalChecks,
    DisableInternalChecksDescription,
    Metadata,
    DisableInternalContractsMetadata,
    DisableInternalContractsMetadataDescription,
    DisablePublicContractsMetadata,
    DisablePublicContractsMetadataDescription,
  }    
  

  public class SR {
    internal const UIStringNames Error = UIStringNames.Error;
    internal const UIStringNames Warning =UIStringNames.Warning;
    internal const UIStringNames ErrorSaving = UIStringNames.ErrorSaving;
    internal const UIStringNames SaveModifiedDocuments = UIStringNames.SaveModifiedDocuments;
    internal const UIStringNames SaveCaption = UIStringNames.SaveCaption;
    internal const UIStringNames FileAlreadyInProject = UIStringNames.FileAlreadyInProject;
    internal const UIStringNames FileAlreadyInProjectCaption = UIStringNames.FileAlreadyInProjectCaption;
    internal const UIStringNames FileAlreadyExists = UIStringNames.FileAlreadyExists;
    internal const UIStringNames FileAlreadyExistsCaption = UIStringNames.FileAlreadyExistsCaption;
    internal const UIStringNames None = UIStringNames.None;
    internal const UIStringNames Compile = UIStringNames.Compile;
    internal const UIStringNames Content = UIStringNames.Content;
    internal const UIStringNames EmbeddedResource = UIStringNames.EmbeddedResource;
    internal const UIStringNames Program = UIStringNames.Program;
    internal const UIStringNames URL = UIStringNames.URL;
    internal const UIStringNames Project = UIStringNames.Project;
    internal const UIStringNames v1 = UIStringNames.v1;
    internal const UIStringNames v11 = UIStringNames.v11;
    internal const UIStringNames v12 = UIStringNames.v12;
    internal const UIStringNames v2 = UIStringNames.v2;
    internal const UIStringNames cli1 = UIStringNames.cli1;
    internal const UIStringNames Exe = UIStringNames.Exe;
    internal const UIStringNames Library = UIStringNames.Library;
    internal const UIStringNames WinExe = UIStringNames.WinExe;
    internal const UIStringNames FileProperties = UIStringNames.FileProperties;
    internal const UIStringNames ProjectProperties = UIStringNames.ProjectProperties;
    internal const UIStringNames FolderProperties = UIStringNames.FolderProperties;
    internal const UIStringNames ReferenceProperties = UIStringNames.ReferenceProperties;
    internal const UIStringNames BuildAction = UIStringNames.BuildAction;
    internal const UIStringNames BuildActionDescription = UIStringNames.BuildActionDescription;
    internal const UIStringNames CustomTool = UIStringNames.CustomTool;
    internal const UIStringNames CustomToolDescription = UIStringNames.CustomToolDescription;
    internal const UIStringNames CustomToolNamespace = UIStringNames.CustomToolNamespace;
    internal const UIStringNames CustomToolNamespaceDescription = UIStringNames.CustomToolNamespaceDescription;
    internal const UIStringNames FileName = UIStringNames.FileName;
    internal const UIStringNames FileNameDescription = UIStringNames.FileNameDescription;
    internal const UIStringNames FullPath = UIStringNames.FullPath;
    internal const UIStringNames FullPathDescription = UIStringNames.FullPathDescription;
    internal const UIStringNames Advanced = UIStringNames.Advanced;
    internal const UIStringNames Misc = UIStringNames.Misc;
    internal const UIStringNames ProjectFile = UIStringNames.ProjectFile;
    internal const UIStringNames ProjectFileDescription = UIStringNames.ProjectFileDescription;
    internal const UIStringNames ProjectFolder = UIStringNames.ProjectFolder;
    internal const UIStringNames ProjectFolderDescription = UIStringNames.ProjectFolderDescription;
    internal const UIStringNames FolderName = UIStringNames.FolderName;
    internal const UIStringNames FolderNameDescription = UIStringNames.FolderNameDescription;
    internal const UIStringNames RefName = UIStringNames.RefName;
    internal const UIStringNames RefNameDescription = UIStringNames.RefNameDescription;
    internal const UIStringNames CopyToLocal = UIStringNames.CopyToLocal;
    internal const UIStringNames CopyToLocalDescription = UIStringNames.CopyToLocalDescription;

    static WeakReference rm;
    public static ResourceManager GetResourceManager(){
      ResourceManager rmgr = rm == null ? null : (ResourceManager)rm.Target;
      if (rmgr == null) {
        rm = new WeakReference(rmgr = new ResourceManager("Microsoft.VisualStudio.Package.Project.UIStrings", typeof(SR).Assembly)); 
      }
      return rmgr;
    }
    public static string GetString(UIStringNames name) {
      return GetResourceManager().GetString(name.ToString());
    }
    public static string GetString(UIStringNames name, CultureInfo culture) {
      return GetResourceManager().GetString(name.ToString(), culture);
    }
    public static string GetString(string name, CultureInfo culture) {
      return GetResourceManager().GetString(name, culture);
    }    
  }
}