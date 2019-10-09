class House(object):
    def __init__(self, *args):
        super(House, self).__init__(*args)
        self.temp = 0

    def warmUp(self):
        self.temp += 1

    def warmUp(self, amount):
        self.temp += amount


class TV(object):
    def __init__(self, *args):
        super(TV, self).__init__(*args)
        self.channel = ""
        self.language = ""

    def chageChannel(self, new_channel):
        self.channel += new_channel

    def changeLanguage(self, new_language):
        self.language = new_language


class Closet(object):
    def __init__(self, *args):
        super(Closet, self).__init__(*args)
        self.shirts = []

    def addShirt(self, shirt):
        self.shirts.append(shirt)

    def showShirts(self):
        print(self.shirts)

    def removeShirt(self, shirt):
        self.shirts.remove(shirt)
