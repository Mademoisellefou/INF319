from pyswip import Prolog
prolog = Prolog()
prolog.assertz("padre(homer,bart)")
prolog.assertz("padre(buner,marge)")
prolog.assertz("padre(alf,lib)")
prolog.assertz("padre(awer,carla)")
prolog.assertz("padre(robert,awer)")
prolog.assertz("padre(robert,alf)")
prolog.assertz("madre(marge,lisa)")
prolog.assertz("madre(ely,lib)")
prolog.assertz("madre(lia,alf)")
prolog.assertz("hijo(Y,X) :- padre(X,Y)")
prolog.assertz("abuelo(X,Y) :- madre(Z,Y),padre(X,Z)")
prolog.assertz("nieto(M,L):- padre(X,M),madre(L,X);madre(X,M),madre(L,X)")
prolog.assertz("hermano(B,L):- padre(X,B),padre(X,L),not(B=L)")
prolog.assertz("primo(C,M):-padre(X,C),hermano(X,Y),padre(Y,M)")
print("_"*12)
# Primos
for soln in prolog.query("primo(X,Y)"):
    print(soln["X"], "es Prim(o/a) de", soln["Y"])
print("_"*12)
#nieto
for soln in prolog.query("nieto(X,Y)"):
    print(soln["X"],"es niet(o/a) de ",soln["Y"])
print("_"*12)
#abuelo
for soln in prolog.query("abuelo(X,Y)"):
    print(soln["X"],"es abuel(o/a) de ",soln["Y"])
