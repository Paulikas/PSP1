from ChildClasses import SecureHouse, TVNetflix, ClosetShoes

sh = SecureHouse()
tn = TVNetflix()
cs = ClosetShoes()

sh.checkWindows()
sh.warmUp(22)
print(sh.temp)

tn.chageChannel("Netflix")
tn.browsMovies()

cs.addShirt("Blue")
print(cs.shirts)
cs.addShoe("Sneaker")
print(cs.shoes)
