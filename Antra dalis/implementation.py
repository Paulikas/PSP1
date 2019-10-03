from FlightTemplate import FlightInsurance as I, FlightType as T


class privateCargo(I, T):
    def __init__(self, pilotClass, lastMaintenance, distance, landingLocation):
        I.__init__(self, pilotClass, lastMaintenance)
        T.__init__(self, distance, landingLocation)

    def checkPilotClass(self, pilotClass):
        if pilotClass == "Good":
            return 300
        else:
            return 350

    def checkLastMaintenance(self, lastMaintenance):
        return lastMaintenance * 120

    def permissionCost(self, landingLocation):
        if landingLocation == "Good":
            return 300
        else:
            return 350

    def fuelCost(self, distance):
        return distance * 0.65

    def calPrice(self):
        return self.calCost()+self.calInsurence()
