// code en stock en C# pour WinForm et DLL

public static string DisplayTitle()
{
  Assembly assembly = Assembly.GetExecutingAssembly();
  FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
  return $" V{fvi.FileMajorPart}.{fvi.FileMinorPart}.{fvi.FileBuildPart}.{fvi.FilePrivatePart}"; // doesn't build in appveyor
}

