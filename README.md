# Xamarin-forms
Tutorial on Building Native Cross-platform Apps with C# 

## Layouts
### .xaml and Codebehind files in HelloWorld project
- StackPage - Stack Layout
- GridPage - Grid Layout
- AbsolutePage - Absolute Layout
- RelativePage - Relative Layout

## Images
### .xaml and Codebehind files in HelloWorld project
- ImagePage - Image Sources, Downloaded Images, Aspects, Activity Indicator, Embedded Images
- PlatformSpecificImages
- RoundedImages - Using a NuGet package for rounded images

## Lists
### .xaml and Codebehind files in Lists project
- BasicList - Creating a basic list from Contact class and used Binding in xaml to show user name, status, and image with a ListView and ItemTemplate using TextCell and ImageCell as built in options. Used ViewCell as a custom list view option.
- GroupedList - Created ContactGroup class to group Contacts by first letter. Used IsGroupingEnabled and GroupDisplayBinding to group contacts in list view
- ListSelections - Created ItemTapped and ItemSelected event listeners to handle selections
- ContextActions - Created swipe left(iOS)/ hold(Android) list item event to show additional Call and Delete buttons. Used ObservableCollection to update view anytime the contact list is changed
- PullToRefresh - Added pull to refresh event to update contacts on pull
- SearchBar - Added search bar to filter through contact list on Text Change