class Student:
    """Student class"""
    def __init__(self, last_name, first_name, major, gpa=0.0):

        if any(char.isdigit() for char in last_name):
            raise Exception("Only letters are allowed for last name")
        else:
            self.last_name = last_name

        if any(char.isdigit() for char in first_name):
            raise Exception("Only letters are allowed for first name")
        else:
            self.first_name = first_name

        if any(char.isdigit() for char in major):
            raise Exception("Only letters are allowed for major")
        else:
            self.major = major

        if any(char.isalpha() for char in str(gpa)):
            raise Exception("Only number are allowed for gpa")
        else:
            self.gpa = gpa

    def __str__(self):
        return self.last_name + ", " + self.first_name + " has major " + self.major + " with gpa: " + str(self.gpa)
