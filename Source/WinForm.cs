// code en stock en C# pour WinForm et DLL

public static string DisplayTitle()
{
  Assembly assembly = Assembly.GetExecutingAssembly();
  FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
  return $" V{fvi.FileMajorPart}.{fvi.FileMinorPart}.{fvi.FileBuildPart}.{fvi.FilePrivatePart}"; // doesn't build in appveyor
}

public static string GetServerArchitecture()
{
  return Environment.Is64BitOperatingSystem ? "X64" : "X86";
}

public static string GetEnvironment64BitProcess()
{
  return Environment.Is64BitProcess ? "X64" : "X86";
}

public static string GetwindowsPath()
{
  return Environment.GetEnvironmentVariable("Path");
}