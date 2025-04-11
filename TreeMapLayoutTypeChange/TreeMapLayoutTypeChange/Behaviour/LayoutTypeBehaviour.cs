using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Maui.Inputs;
using Syncfusion.Maui.TreeMap;

namespace TreeMapLayoutTypeChange
{
    public class LayoutTypeBehaviour : Behavior<ContentPage>
    {
        #region Fields

        /// <summary>
        /// The tree map instance.
        /// </summary>
        private SfTreeMap? treeMap;

        /// <summary>
        /// The combobox instance
        /// </summary>
        private SfComboBox? comboBox;

        #endregion

        #region Override methods

        /// <summary>
        /// Invoked when behavior is attached to a view.
        /// </summary>
        /// <param name="sampleView">The sample view to which the behavior is attached.</param>
        protected override void OnAttachedTo(ContentPage sampleView)
        {
            base.OnAttachedTo(sampleView);
            this.treeMap = sampleView.FindByName<SfTreeMap>("treeMap");
            this.comboBox = sampleView.FindByName<SfComboBox>("comboBox");
            if (this.comboBox != null)
            {
                this.comboBox.SelectionChanged += OnComboBoxSelectionChanged;
            }
        }

        /// <summary>
        /// Invoked when behavior is detached from a view.
        /// </summary>
        /// <param name="sampleView">The sample view from which the behavior is detached.</param>
        protected override void OnDetachingFrom(ContentPage sampleView)
        {
            base.OnDetachingFrom(sampleView);

            if (this.treeMap != null)
            {
                this.treeMap = null;
            }

            if (this.comboBox != null)
            {
                this.comboBox.SelectionChanged -= OnComboBoxSelectionChanged;
                this.comboBox = null;
            }
        }

        #endregion

        #region Property changed

        /// <summary>
        /// Invokes on combobox selection changed.
        /// </summary>
        /// <param name="sender">The combobox.</param>
        /// <param name="e">The event args.</param>
        private void OnComboBoxSelectionChanged(object? sender, Syncfusion.Maui.Inputs.SelectionChangedEventArgs e)
        {
            if (comboBox?.SelectedIndex == 0)
            {
                treeMap.LayoutType = LayoutType.Squarified;
            }

            else if (comboBox?.SelectedIndex == 1)
            {
                treeMap.LayoutType = LayoutType.SliceAndDiceAuto;
            }

            else if (comboBox?.SelectedIndex == 2)
            {
                treeMap.LayoutType = LayoutType.SliceAndDiceHorizontal;
            }

            else if (comboBox?.SelectedIndex == 3)
            {
                treeMap.LayoutType = LayoutType.SliceAndDiceVertical;
            }
        }

        #endregion
    }
}
