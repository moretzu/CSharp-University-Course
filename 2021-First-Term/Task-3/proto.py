import random as rnd
from pprint import pprint

size = int(input("Укажите размер квадратной матрицы: "))

matrice = []
for n in range(0, size):
    matrice.append([rnd.randint(1, 10) for _ in range(0, size)])
    
pprint(matrice)