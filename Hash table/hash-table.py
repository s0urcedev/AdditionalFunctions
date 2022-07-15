from math import sqrt
from typing import Any

class HashTable:

    __size: int = 0
    __table: list = []

    def __isprime(self, n: int) -> bool:
        result: list = []
        d: int = 2
        while d * d <= n:
            if n % d == 0:
                result.append(d)
                n //= d
            else:
                d += 1
        if n > 1:
            result.append(n)
        if len(result) > 1: return False
        else: return True

    def __nearest_prime(self, n: int) -> int:
        if n % 2 == 0:
            n += 1
        while not self.__isprime(n):
            n += 2
        return n

    def __count_hash(self, s: str) -> int:
        n: int = 7
        for c in s:
            n = n * 31 + ord(c)
        return int(self.__size * (n * ((sqrt(5) - 1) / 2) % 1))

    def __init__(self, size: int) -> None:
        self.__size = self.__nearest_prime(size)
        self.__table = [None for _ in range(0, self.__size)]

    def search(self, key: str) -> Any:
        return self.__table[self.__count_hash(key)]

    def insert(self, key: str, value: Any) -> None:
        self.__table[self.__count_hash(key)] = value

    def remove(self, key: str) -> None:
        self.__table[self.__count_hash(key)] = None