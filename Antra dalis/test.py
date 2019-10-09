from implementation import privateCargo, AirLinesCargo

x = privateCargo("A", 2, 2000, "Good")
y = AirLinesCargo("A", 6, 9000, "Unplaned")

print(x.__class__)
print(x.calCost())
print(x.calInsurence())
print(x.calPrice())

print(y.__class__)
print(y.calCost())
print(y.calInsurence())
print(y.calPrice())
