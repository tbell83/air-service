select distinct
	airService_Carriers.carrierName,
	airService_Carriers.carrierID
from airService_Carriers
	left join airService_Flights on airService_Carriers.carrierID = airService_Flights.carrierID
	left join airService_Airports as OriginAirport on OriginAirport.airportID = airService_Flights.originAirport
	left join airService_Airports as DesitinationAirport on DesitinationAirport.airportID = airService_Flights.destinationAirport
	left join airService_Cities as DestinationCity on DesitinationAirport.cityID = DestinationCity.cityID
	left join airService_Cities as OriginCity on OriginAirport.cityID = OriginCity.cityID
where
	OriginCity.State like '%%'
	and
	OriginCity.cityName like '%%'
	and
	DestinationCity.State like '%%'
	and
	DestinationCity.cityName like '%%'