import unittest
from class_definitions import student as s
from class_definitions.student import Student


class MyTestCase(unittest.TestCase):
    def setUp(self):
        self.student = Student('Duck', 'Daisy', 'CS', 3.5)

    def tearDown(self):
        del self.student

    def test_object_created_required_attributes(self):
        self.assertEqual(self.student.last_name, 'Duck')
        self.assertEqual(self.student.first_name, 'Daisy')
        self.assertEqual(self.student.major, 'CS')

    def test_object_created_all_attributes(self):
        s2 = Student('Mouse', 'Mickey', 'Business', 2.2)
        assert s2.last_name == 'Mouse'
        assert s2.first_name == 'Mickey'
        assert s2.major == 'Business'
        assert s2.gpa == 2.2

    def test_object_not_created_error_last_name(self):
        with self.assertRaises(Exception):
            t = Student('123', 'Daisy', 'CS', 3.5)

    def test_object_not_created_error_first_name(self):
        with self.assertRaises(Exception):
            t = Student('Duck', '123', 'CS', 3.5)

    def test_object_not_created_error_major(self):
        with self.assertRaises(Exception):
            t = Student('Duck', 'Daisy', '123', 3.5)

    def test_object_not_created_error_gpa(self):
        with self.assertRaises(Exception):
            t = Student('Duck', 'Daisy', 'CS', 'Good enough')

    def test_student_str(self):
        self.assertEqual(str(self.student), 'Duck, Daisy has major CS with gpa: 3.5')


if __name__ == '__main__':
    unittest.main()
