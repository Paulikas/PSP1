from FlightTemplate import Flight as F, Private, AirLines


class privateCargo(F, Private):
    def __init__(self, *args):
        super(privateCargo, self).__init__(*args)

    def checkPilotClass(self, pilotClass):
        if pilotClass == "Good":
            return 300
        else:
            return 350

    def checkLastMaintenance(self, lastMaintenance):
        return lastMaintenance * 120

    def permissionCost(self, landingLocation):
        return Private.permissionCost(self, landingLocation)

    def fuelCost(self, distance):
        return Private.fuelCost(self, distance)


class AirLinesCargo(F, AirLines):
    def __init__(self, *args):
        super(AirLinesCargo, self).__init__(*args)

    def checkPilotClass(self, pilotClass):
        if pilotClass == "Good":
            return 300
        else:
            return 350

    def checkLastMaintenance(self, lastMaintenance):
        return lastMaintenance * 120

    def permissionCost(self, landingLocation):
        return AirLines.permissionCost(self, landingLocation)

    def fuelCost(self, distance):
        return AirLines.fuelCost(self, distance)
