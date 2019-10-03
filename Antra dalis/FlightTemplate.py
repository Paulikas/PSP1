class FlightInsurance():

    pilotClass = ""
    lastMaintenace = 0
    weather = ""

    def __init__(self, pilotClass, lastMaintenance):
        self.pilotClass = pilotClass
        self.lastMaintenace = lastMaintenance

    def checkPilotClass(self, pilotClass):
        pass

    def checkLastMaintenance(self, lastMaintenance):
        pass

    def calInsurence(self):
        return self.checkLastMaintenance(self.lastMaintenace) + self.checkPilotClass(self.pilotClass)


class FlightType():
    distance = 0
    landingLocation = ""

    def __init__(self, distance, landingLocation):
        self.distance = distance
        self.landingLocation = landingLocation

    def permissionCost(self, landingLocation):
        pass

    def fuelCost(self, distance):
        pass

    def calCost(self):
        return self.permissionCost(self.landingLocation)+self.fuelCost(self.distance)
