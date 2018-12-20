Public Class qmsClass
    Private Shared m_version As New Version(Application.ProductVersion)

    Public Shared ReadOnly Property Version() As Version
        Get
            Return m_version
        End Get
    End Property
    'LabelVersion.Text = String.Format("Version {0}.{1}",
    'Program.Version.Major.ToString(),
    'Program.Version.Minor.ToString());
End Class
