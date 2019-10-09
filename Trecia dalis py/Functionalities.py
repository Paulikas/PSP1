class windowSecurity(object):
    def __init__(self, *args):
        super(windowSecurity, self).__init__(*args)
        self.windows = {"kitchen": False, "living_room": False}

    def checkWindows(self):
        for key, value in self.windows.items():
            if value:
                print(f'{key} windows is not closed')

    def openWindow(self, window):
        try:
            self.windows[window] = True
        except:
            print("There is no such window")

    def closeWindow(self, window):
        try:
            self.windows[window] = False
        except:
            print("There is no such window")


class Netflix(object):
    def __init__(self, *args):
        super(Netflix, self).__init__(*args)
        self.movies = ["Love, death and robots", "Bright"]

    def playMovie(self, movie):
        if movie in self.movies:
            print(f'Now playing {movie}')

    def browsMovies(self):
        print(self.movies)


class Shoes(object):
    def __init__(self, *args):
        super(Shoes, self).__init__(*args)
        self.shoes = []

    def addShoe(self, shoe):
        self.shoes.append(shoe)

    def showShoes(self):
        print(self.shoe)
