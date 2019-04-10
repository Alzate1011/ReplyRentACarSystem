# ReplyRentACarSystem

DataSchema
{
  "Car": {
    "Id": 1,
    "Model": "Porshe 911 GT3",
    "Year": 2019,
    "GalleryURL": "Porshe.com",
    "Passengers": 2,
    "Engine": {
      "HP": 232,
      "Cilinders": 6,
      "Torque": 470
    },
    "InfotainSystem": {
      "ScreenSize": 14,
      "Sound": "Bose"
    },
    "InteriorDesign": {
      "Seats": "Leather",
      "Color": "Red"
    },
    "CurrentLocation": {
      "Date": "04-09-2019 18:23:00 CST",
      "Lat": 4.570868,
      "Long": 74.2973328
    }
  },
  "HistoricLocations": [
    {
      "CarId": 1,
      "Date": "04-09-2019 18:23:00 CST",
      "Lat": 4.570868,
      "Long": 74.2973328
    },
    {
      "CarId": 1,
      "Date": "04-09-2019 18:25:00 CST",
      "Lat": 4.570870,
      "Long": -74.2973330
    }
  ],
  "User": {
    "Id": 2,
    "Name": "John Doe",
    "Gender": "Male",
    "Age": 30
  },
  "Demand": {
    "UserId": 1,
    "CreateDate": "04-09-2019 18:25:00 CST",
    "PickUpLocation": {
      "Lat": 4.570870,
      "Long": -74.2973330
    },
    "DropOffLocation": {
      "Lat": 4.570870,
      "Long": -74.2973330
    },
    "EarliestPickUpTime": "04-09-2019 18:25:00 CST",
    "LatestDropOffTime": "04-09-2019 18:25:00 CST",
    "DesiredFeatures": {
      "Passengers": 2,
      "MinYear": 2015,
      "Engine": {
        "MaxHP": 300,
        "MinHP": 200,
        "MaxCilinders": 8,
        "MinCilinders": 6
      },
      "InfotainSystem": {
        "SoundBrands": [ "Bose", "Sony" ]
      },
      "InteriorDesign": {
        "Colors": [ "Red", "Black" ]
      }
    }
  }

}
