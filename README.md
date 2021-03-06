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
- BasicList
    - Creating a basic list from Contact class 
    - Used Binding in xaml to show user name, status, and image with a ListView and ItemTemplate 
    - Used TextCell and ImageCell as built in options to create binded lists
    - Used ViewCell as a custom list view option to create binded lists
- GroupedList 
    - Created ContactGroup class to group Contacts by first letter
    - Used IsGroupingEnabled and GroupDisplayBinding to group contacts in list view
- ListSelections 
    - Created ItemTapped and ItemSelected event listeners to handle selections
- ContextActions
    - Created swipe left(iOS)/ hold(Android) list item event to show additional Call and Delete buttons
    - Used ObservableCollection to update view anytime a new item is added or an existing item is removed from contact list
- PullToRefresh
    - Added pull to refresh event to update contacts on pull
- SearchBar
    - Added search bar to filter through contact list on Text Change

## Navigation
### .xaml and Codebehind files in Navigation project
- HierarchicalNavigation
    - Added navigation to app by adding MainPage = new NavigationPage(new HierarchicalNavigation()) to App.xaml.cs
    - Added Navigation.PushAsync to navigate to next page and Navigation.PopAsync to go to previous page
    - Changed background color and text color of NavBar in App.xaml.cs file
    - Overrode OnBackButtonPressed() to disable back button functionality
    - Modal Pages
        - Add Navigation.PushModalAsync and Navigation.PopModalAsync to navigate to modal pages
- ContactsPage & ContactDetailPage - Simple Master Detail
    - Added ItemSelected Handler to ListView
    - Added await Navigation.PushAsync(new ContactDetailPage(contact)) to send contact data to contactDetailPage
    - Added contact as an arguments in ContactDetailPage constructor
    - Set BindingContext to contact
    - Retreived contact data in .xaml file by using Binding