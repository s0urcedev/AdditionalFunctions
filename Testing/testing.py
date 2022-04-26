from typing import Any, Callable

class Test:
    
    __func: Callable[..., Any] = None
    __params: list = []
    __results: list = []

    def __init__(self, func: Callable[..., Any] = None) -> None:
        self.__func = func

    def set_func(self, func: Callable[..., Any]) -> None:
        self.__func = func

    def get_func(self) -> Callable[..., Any]:
        return self.__func

    def test(self, *args: list) -> bool:
        if len(args) == 2:
            if self.__func == None:
                print("No function set")
                return
            return self.__func(*args[0]) == args[1]
        elif len(args) == 3:
            return args[0](*args[1]) == args[2]
        else:
            print("Invalid number of arguments");
            return

    def add_test_cases(self, *args: list) -> None:
        for a in args:
            self.__params.append(a[0])
            self.__results.append(a[1])
    
    def show_test_cases(self) -> None:
        if(len(self.__params) == 0):
            print("No test cases")
        for i in range(0, len(self.__params)):
            print("Arguments: {}, Correct result: {}".format([*self.__params[i]], self.__results[i]))

    def clear_test_cases(self) -> None:
        self.__params = []
        self.__results = []

    def test_all(self) -> bool:
        if self.__func == None:
            print("No function set")
            return
        for i in range(0, len(self.__params)):
            if self.__func(*self.__params[i]) != self.__results[i]:
                return False
        return True

    def find_valid(self) -> list:
        if self.__func == None:
            print("No function set")
            return
        result: list = []
        for i in range(0, len(self.__params)):
            try:
                if self.__func(*self.__params[i]) == self.__results[i]:
                    result.append([[*self.__params[i]], self.__results[i]])
            except:
                pass
        return result

    def find_invalid(self) -> list:
        if self.__func == None:
            print("No function set")
            return
        result: list = []
        for i in range(0, len(self.__params)):
            try:
                if self.__func(*self.__params[i]) != self.__results[i]:
                    result.append([[*self.__params[i]], self.__results[i]])
            except:
                pass
        return result

    def find_failed(self) -> list:
        if self.__func == None:
            print("No function set")
            return
        result: list = []
        for i in range(0, len(self.__params)):
            try:
                self.__func(*self.__params[i])
            except:
                result.append([[*self.__params[i]], self.__results[i]])
        return result

    def print_results(self) -> None:
        if self.__func == None:
            print("No function set")
            return
        print("Function: {}".format(self.__func.__name__))
        totaly: dict = {"valid": 0, "invalid": 0, "failed": 0}
        for i in range(0, len(self.__params)):
            try:
                if self.__func(*self.__params[i]) != self.__results[i]:
                    print("Arguments: {}, Correct result: {}, Desicion: INVALID".format([*self.__params[i]], self.__results[i]))
                    totaly["invalid"] += 1
                else:
                    print("Arguments: {}, Correct result: {}, Desicion: VALID".format([*self.__params[i]], self.__results[i]))
                    totaly["valid"] += 1
            except Exception as err:
                    print("Arguments: {}, Correct result: {}, Desicion: FAILED ( {} )".format([*self.__params[i]], self.__results[i], err))
                    totaly["failed"] += 1
        print("Totaly: {} VALID, {} INVALID, {} FAILED".format(totaly["valid"], totaly["invalid"], totaly["failed"]))