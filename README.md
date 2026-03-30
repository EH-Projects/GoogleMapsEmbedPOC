This POC is to show off using the google maps javascript api and the google geocoder api by allowing you to insert a zipcode or full address and see it on an embedded google maps.<br><br>
This POC requires you to have your own google API key and optionally a map ID.<br>
<br>
There are two versions:<br>
Simple Map: a simple map embed with two overlay options to play around with and only requires an API key and location info.<br><br>
Advanced Map: the advanced map allows you to have a third overlay option of a colored in boundary around the zip but also requires a map ID. 
Map IDs are from adding visual preference entries for google map API usage and have to be setup through the google cloud platform.<br><br>
This project uses two different types or pin point markers as well.<br>
The simple map uses the deprecated marker library because they still funciton and don't require a map ID<br>
The advanced map uses advanced markers which is the replacement for the older markers, they have more Customizability, But require usage of the map ID.
