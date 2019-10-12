from abc import ABC, abstractmethod


class Flight():

    pilotClass = ""
    lastMaintenace = 0
    distance = 0
    landingLocation = ""

    def __init__(self, pilotClass, lastMaintenance, distance, landingLocation):
        self.pilotClass = pilotClass
        self.lastMaintenace = lastMaintenance
        self.distance = distance
        self.landingLocation = landingLocation

    def checkPilotClass(self, pilotClass):
        pass

    def checkLastMaintenance(self, lastMaintenance):
        pass

    def calInsurence(self):
        print("lasM: "+str(self.checkLastMaintenance(self.lastMaintenace)))
        print("pilot: "+str(self.checkPilotClass(self.pilotClass)))
        return self.checkLastMaintenance(self.lastMaintenace) + self.checkPilotClass(self.pilotClass)

    def permissionCost(self, landingLocation):
        pass

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


class AirBus(object):
    def checkPilotClass(self, pilotClass):
        if pilotClass == "F":
            return 2000.66
        elif pilotClass == "E":
            return 1875.25
        elif pilotClass == "D":
            return 1605.23
        else:
            return 1540.36

    def checkLastMaintenance(self, lastMaintenance):
        return lastMaintenance * 250


class Cargo(object):

    def checkPilotClass(self, pilotClass):
        if pilotClass == "Good":
            return 300
        else:
            return 350

    def checkLastMaintenance(self, lastMaintenance):
        return lastMaintenance * 120
