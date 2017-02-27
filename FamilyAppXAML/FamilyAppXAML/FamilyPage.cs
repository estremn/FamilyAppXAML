using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FamilyAppXAML
{
    public class FamilyPage : ContentPage
    {
        public FamilyPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Scale = 1.5, FontAttributes = FontAttributes.Bold, Text = "My Family" },

                    new Label { Scale = .8, Text = "I don't know half of them half of what I should like, "
                    + "and like half of them half as well as they deserve." },

                    new Label { Scale = 1, FontAttributes = FontAttributes.Bold,  Text = "Tammy Estrem" },
                }
            };
        }
    }
}
