using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shalom
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cursos : ContentPage
	{
		public Cursos ()
		{
			InitializeComponent ();
            this.Title = "Cursos";

		}
	}
}