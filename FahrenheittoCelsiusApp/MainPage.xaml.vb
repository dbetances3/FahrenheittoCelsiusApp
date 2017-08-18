' Program:      Fahrenheit to Celsius Conversion App
' Developer:    Diana Betances
' Date:         December 8, 2015
' Purpose:      This Windows Store app opens with a splash screen and allows a user
'               to convert a Fahrenheit temperature to a Celsius temperature.

Option Strict On
' The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

''' <summary>
''' A basic page that provides characteristics common to most applications.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Common.LayoutAwarePage

        ''' <summary>
        ''' Populates the page with content passed during navigation.  Any saved state is also
        ''' provided when recreating a page from a prior session.
        ''' </summary>
        ''' <param name="navigationParameter">The parameter value passed to
        ''' <see cref="Frame.Navigate"/> when this page was initially requested.
        ''' </param>
        ''' <param name="pageState">A dictionary of state preserved by this page during an earlier
        ''' session.  This will be null the first time a page is visited.</param>
        Protected Overrides Sub LoadState(navigationParameter As Object, pageState As Dictionary(Of String, Object))

        End Sub

        ''' <summary>
        ''' Preserves state associated with this page in case the application is suspended or the
        ''' page is discarded from the navigation cache.  Values must conform to the serialization
        ''' requirements of <see cref="Common.SuspensionManager.SessionState"/>.
        ''' </summary>
        ''' <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        Protected Overrides Sub SaveState(pageState As Dictionary(Of String, Object))

        End Sub

    Private Sub btnConvert_Click(sender As Object, e As RoutedEventArgs) Handles btnConvert.Click

        'Declaration of app variables
        Dim C As Double
        Dim F As Double



        'Compute and display the Fahrenheit temperature to a Celsius temperature
        F = Double.Parse(txtFahrenheitTemp.Text)
        C = 5.0 / 9.0 * (F - 32)
        lblResult.Text = C.ToString("N1") + " Degrees "


    End Sub
End Class
