## Description

On iOS, ScrollView does not detect content size change within StackLayout,
not allowing to scroll when a StackLayout within a ScrollView is filled after
the view was attached.

## Github issues

* dotnet/maui#8820
* dotnet/maui#9209

## Steps to Reproduce

Run the attached sample on iOS
* Hit the _Add many items_ Button
  * 30 items are added to the view, filling the whole space but scrolling is not possible
* Hit the _Fix bug_ Switch (turn on)
* Hit the _Add many items_ Button
  * You can now scroll the view and see the 60 items in the list
* Hit the _Fix bug_ Switch (turn off)
* Hit the _Add many items_ Button
  * You can only scroll past the first 60 items
* Hit the _InvalidateMeasure_ button
  * You can now scroll the view and see the 90 items in the list

## Version with bug
7.0.100 (current)

## Last version that worked well
Unknown

## Affected platforms
iOS

## Affected platform versions
iOS 16.2 (and probably all earlier versions)

## Did you find any workaround?
Bind the `StackLayout.PropertyChanged` event and call `InvalidateMeasure` on the ScrollView
whenever the StackLayout's `Height` or `Width` property is changed.

## Relevant log output
No response