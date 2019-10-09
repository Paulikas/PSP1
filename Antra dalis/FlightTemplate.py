from abc import ABC, abstractmethod


class Flight(ABC):

    pilotClass = ""
    lastMaintenace = 0
    weather = ""
    distance = 0
    landingLocation = ""

    def __init__(self, pilotClass, lastMaintenance, distance, landingLocation):
        self.pilotClass = pilotClass
        self.lastMaintenace = lastMaintenance
        self.distance = distance
        self.landingLocation = landingLocation

    @abstractmethod
    def checkPilotClass(self, pilotClass):
        pass

    @abstractmethod
    def checkLastMaintenance(self, lastMaintenance):
        pass

    def calInsurence(self):
        return self.checkLastMaintenance(self.lastMaintenace) + self.checkPilotClass(self.pilotClass)

    @abstractmethod
    def permissionCost(self, landingLocation):
        pass

    @abstractmethod
    def fuelCost(self, distance):
        pass

    def calCost(self):
        return self.permissionCost(self.landingLocation)+self.fuelCost(self.distance)

    def calPrice(self):
        return self.calCost()+self.calInsurence()


class Private():

    def permissionCost(self, landingLocation):
        if landingLocation == "Good":
            return 300
        else:
            return 350

    def fuelCost(self, distance):
        return distance * 0.65


class AirLines():

    def permissionCost(self, landingLocation):
        if landingLocation == "Planned":
            return 300
        else:
            return 1200.15

    def fuelCost(self, distance):
        return distance * 0.77
