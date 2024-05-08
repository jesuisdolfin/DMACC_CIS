class Employee:

    def __init__(self, last_name, first_name, address, phone, salaried, start_date, salary):
        self.last_name = last_name
        self.first_name = first_name
        self.address = address
        self.phone = phone
        self.salaried = salaried
        self.start_date = start_date
        self.salary = salary

    def set_last_name(self, last_name):
        self.last_name = last_name

    def set_first_name(self, first_name):
        self.first_name = first_name

    def set_address(self, address):
        self.address = address

    def set_phone(self, phone):
        self.phone = phone

    def set_salaried(self, salaried):
        self.salaried = salaried

    def set_start_date(self, start_date):
        self.start_date = start_date

    def set_salary(self, salary):
        self.salary = salary

    def display(self):
        if self.salaried:
            msg = str(self.last_name) + ", " + str(self.first_name) + "\n" + str(self.address) + "\n" + \
              str(self.phone) + "\n" + "Salaried: " + str(self.salaried) + "\n" + "Started: " + \
              str(self.start_date) + "\n" + "Pay: $" + str(self.salary) + "/year"
        else:
            msg = str(self.last_name) + ", " + str(self.first_name) + "\n" + str(self.address) + "\n" + \
                  str(self.phone) + "\n" + "Salaried: " + str(self.salaried) + "\n" + "Started: " + \
                  str(self.start_date) + "\n" + "Pay: $" + str(self.salary) + "/hour"

        return msg + "\n"


if __name__ == '__main__':
    test1 = Employee("Dolphin", "Charlie", "123 Street", "123-456-7891", True, "Today", 100000)
    test2 = Employee("Loser", "McNosalary", "123 Broke Street", "123-456-0000", False, "Tomorrow", 15)
    print(test1.display())
    print(test2.display())
