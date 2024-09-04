<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128616319/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E708)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Bars - Create and customize bar edit items at runtime

This example creates two [bar edit items](https://docs.devexpress.com/WindowsForms/DevExpress.XtraBars.BarEditItem) (combobox and progress bar) and places them on top and status bars.

![WinForms Bars - Create and customize bar edit items at runtime(https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-baredititem-at-runtime-e708/13.1.4%2B/media/winforms-bars-edit-items.png)

```csharp
private void Form1_Load(object sender, System.EventArgs e) {
    DevExpress.XtraBars.BarEditItem item;
    DevExpress.XtraEditors.Repository.RepositoryItemComboBox combo;
    DevExpress.XtraEditors.Repository.RepositoryItemProgressBar progress;

    barManager1.ForceInitialize();

    combo = barManager1.RepositoryItems.Add("ComboBoxEdit") as DevExpress.XtraEditors.Repository.RepositoryItemComboBox;
    combo.Items.Add("Item A");
    combo.Items.Add("Item B");
    item = new DevExpress.XtraBars.BarEditItem(barManager1);
    item.Edit = combo;
    item.EditValue = "[n/a]";
    item.Width = 100;
    barStandard.AddItem(item);

    progress = barManager1.RepositoryItems.Add("ProgressBarControl") as DevExpress.XtraEditors.Repository.RepositoryItemProgressBar;
    item = new DevExpress.XtraBars.BarEditItem(barManager1);
    item.Edit = progress;
    item.EditValue = 26; // 26%
    item.Width = 150;
    barStatus.AddItem(item);
}
```

## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))


## Documentation

* [Add Bar Items To Toolbars](https://docs.devexpress.com/WindowsForms/116782/controls-and-libraries/ribbon-bars-and-menu/bars/tutorials/add-bar-items-to-toolbars)


## See Also

* [How to create a BarEditItem at runtime](https://supportcenter.devexpress.com/ticket/details/a2924/how-to-create-a-baredititem-at-runtime)
* [How to avoid problems when adding bar item links to a form when it is loading](https://supportcenter.devexpress.com/ticket/details/a496/how-to-avoid-problems-when-adding-bar-item-links-to-a-form-when-it-is-loading)
* [How to create the main menu at runtime](https://supportcenter.devexpress.com/ticket/details/a2867/how-to-create-the-main-menu-at-runtime)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-bars-create-baredititem&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-bars-create-baredititem&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
