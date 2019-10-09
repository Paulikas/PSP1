from Classes import House, TV, Closet
from Functionalities import windowSecurity as security, Netflix, Shoes


class SecureHouse(House, security):
    def __init__(self, *args):
        super(SecureHouse, self).__init__(*args)


class TVNetflix(TV, Netflix):
    def __init__(self, *args):
        super(TVNetflix, self).__init__(*args)


class ClosetShoes(Closet, Shoes):
    def __init__(self, *args):
        super(ClosetShoes, self).__init__(*args)
