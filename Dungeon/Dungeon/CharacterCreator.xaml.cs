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
    /// A page with controls to create a character with.
    /// </summary>
    public sealed partial class CharacterCreator : Page
    {
        List<Race> races = new List<Race>() { new Human() };
        List<CharacterClass> characterClasses = new List<CharacterClass>() { new Fighter() };

        public CharacterCreator()
        {
            this.InitializeComponent();
            raceComboBox.ItemsSource = races;
            classComboBox.ItemsSource = characterClasses;
        }

        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            var race = (Race)raceComboBox.SelectedValue;
            var chosenClass = (CharacterClass)classComboBox.SelectedItem;
            var stats = new StatBlock(strengthSlider.Value,dexSlider.Value,conSlider.Value,wisSlider.Value,intSlider.Value,chaSlider.Value);
            var player = new Character(characterName.Text, chosenClass, race, stats);
            Frame.Navigate(typeof(CharacterView));
        }
    }
}
