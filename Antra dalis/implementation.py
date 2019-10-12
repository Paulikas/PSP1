from Classes import Flight as F, Private, AirLines, Cargo, AirBus


class privateCargo(Private, Cargo, F):
    '''def __init__(self, *args):
        super(privateCargo, self).__init__(*args)

    def checkPilotClass(self, pilotClass):
        return Cargo.checkPilotClass(self, pilotClass)

    def checkLastMaintenance(self, lastMaintenance):
        return Cargo.checkLastMaintenance(self, lastMaintenance)

    def permissionCost(self, landingLocation):
        return Private.permissionCost(self, landingLocation)

    def fuelCost(self, distance):
        return Private.fuelCost(self, distance)'''


class AirLinesCargo(AirLines, Cargo, F):
    def __init__(self, *args):
        super(AirLinesCargo, self).__init__(*args)
