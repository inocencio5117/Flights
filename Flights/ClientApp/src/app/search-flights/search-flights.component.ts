import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-search-flights',
  templateUrl: './search-flights.component.html',
  styleUrls: ['./search-flights.component.css']
})
export class SearchFlightsComponent implements OnInit {

  searchResults: FlightRm[] = [
    {
      airline: "American Airlines",
      remainingNumberOfSeats: 500,
      departure: { time: Date.now().toString(), place: "Los Angeles" },
      arrival: { time: Date.now().toString(), place: "Istanbul" },
      price: "350"
    },
    {
      airline: "Delta Airlines",
      remainingNumberOfSeats: 450,
      departure: { time: Date.now().toString(), place: "New York" },
      arrival: { time: Date.now().toString(), place: "Paris" },
      price: "400"
    },
    {
      airline: "United Airlines",
      remainingNumberOfSeats: 300,
      departure: { time: Date.now().toString(), place: "Chicago" },
      arrival: { time: Date.now().toString(), place: "London" },
      price: "450"
    },
    {
      airline: "Lufthansa",
      remainingNumberOfSeats: 400,
      departure: { time: Date.now().toString(), place: "Berlin" },
      arrival: { time: Date.now().toString(), place: "Rome" },
      price: "380"
    },
    {
      airline: "Emirates",
      remainingNumberOfSeats: 200,
      departure: { time: Date.now().toString(), place: "Dubai" },
      arrival: { time: Date.now().toString(), place: "Tokyo" },
      price: "550"
    },
    {
      airline: "Singapore Airlines",
      remainingNumberOfSeats: 350,
      departure: { time: Date.now().toString(), place: "Singapore" },
      arrival: { time: Date.now().toString(), place: "Sydney" },
      price: "480"
    }
  ]

  constructor() { }

  ngOnInit(): void {

  }
}

export interface FlightRm {
  airline: string;
  arrival: TimePlaceRm;
  departure: TimePlaceRm;
  price: string;
  remainingNumberOfSeats: number;
}

export interface TimePlaceRm {
  place: string;
  time: string;
}
