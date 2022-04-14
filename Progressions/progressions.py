class ArithmeticProgression:

    __d = 0
    __a = []

    def __init__(self, start = 0, d = 0):
        self.__a.append(start)
        self.__d = d

    def get_sequence(self):
        return self.__a

    def get_difference(self):
        return self.__d

    def set_start_element(self, start):
        self.__a = [start]

    def set_difference(self, d):
        self.__a = [self.__a[0]]
        self.__d = d

    def get_nth(self, n):
        return self.__a[0] + (n - 1) * self.__d
    
    def count_to_nth(self, n):
        for _ in range(len(self.__a), n):
            self.__a.append(self.__a[-1] + self.__d)

    def get_to_nth(self, n):
        self.count_to_nth(n)
        return self.__a

    def get_sum_to_nth(self, n):
        return n * (self.__a[0] + self.get_nth(n)) // 2

class GeometricProgression:

    __r = 1
    __b = []

    def __init__(self, start = 1, r = 1):
        if start == 0 or r == 0:
            print("start_element or ratio can't be 0")
            return 
        self.__b.append(start)
        self.__r = r

    def get_sequence(self):
        return self.__b

    def get_ratio(self):
        return self.__r

    def set_start_element(self, start):
        if start == 0:
            print("start_element can't be 0")
            return
        self.__b = [start]

    def set_ratio(self, r):
        if r == 0:
            print("ratio can't be 0")
            return
        self.__b = [self.__r[0]]
        self.__r = r

    def get_nth(self, n):
        return self.__b[0] * (self.__r ** (n - 1))
    
    def count_to_nth(self, n):
        for _ in range(len(self.__b), n):
            self.__b.append(self.__b[-1] * self.__r)

    def get_to_nth(self, n):
        self.count_to_nth(n)
        return self.__b

    def get_sum_to_nth(self, n):
        if self.__r == 1: return n * self.__b[0]
        return (self.__b[0] * ((self.__r ** n) - 1)) // (self.__r - 1)

    def get_prod_to_nth(self, n):
        return int((self.__b[0] * self.get_nth(n)) ** (n / 2))

class HarmonicProgression:

    __d = 0
    __c = []

    def __init__(self, start = 1, d = 0):
        self.__c.append(start)
        self.__d = d
    
    def get_sequence(self):
        return self.__с

    def get_difference(self):
        return self.__d

    def set_start_element(self, start):
        self.__с = [start]

    def set_difference(self, d):
        self.__с = [self.__с[0]]
        self.__d = d

    def get_nth(self, n):
        return ((self.__c[0] ** -1) + (n - 1) * self.__d) ** -1

    def count_to_nth(self, n):
        for _ in range(len(self.__c), n):
            self.__c.append(((self.__c[-1] ** -1) + self.__d) ** -1)

    def get_to_nth(self, n):
        self.count_to_nth(n)
        return self.__c