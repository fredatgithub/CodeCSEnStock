' code en VB.NET

Private Function GetApplicationVersion() As String
  Dim Assembly As Assembly = Assembly.GetExecutingAssembly()
  Dim fvi As FileVersionInfo = FileVersionInfo.GetVersionInfo(Assembly.Location)
  Return $" V{fvi.FileMajorPart}.{fvi.FileMinorPart}.{fvi.FileBuildPart}"
End Function

