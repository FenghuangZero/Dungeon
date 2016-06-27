using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Dungeon
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CharacterCreatorxaml : Page
    {
        List<Race> races = new List<Race>() { new Human() };
        List<CharacterClass> characterClasses = new List<CharacterClass>() { new Fighter() };

        public CharacterCreatorxaml()
        {            
            raceComboBox.ItemsSource = races;
            classComboBox.ItemsSource = characterClasses;
            this.InitializeComponent();
        }

        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            var race = races.ElementAt(int.Parse(raceComboBox.SelectedValue.ToString()));
            var chosenClass = characterClasses.ElementAt(int.Parse(classComboBox.SelectedItem.ToString());
            var stats = new StatBlock(strengthSlider.Value,dexSlider.Value,conSlider.Value,wisSlider.Value,intSlider.Value,chaSlider.Value);
            var player = new Character(characterName.Text, chosenClass, race, stats);
        }
    }
}
