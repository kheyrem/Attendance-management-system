select Attendance.student_ID from Attendance

select Attendance.AttendanceID, Attendance.student_ID, 
Attendance.Class_id, AllCourses.Course_Name, AllCourses.Course_ID, Attendance.StatusAttd 
from Attendance join AllCourses on AllCourses.Course_ID = Attendance.Course_ID


select AttendanceID, student_ID, Class_id, className, AttDATE, StatusAttd from Attendance  join Class on Class.classID = Attendance.Class_id  join AllCourses on AllCourses.Course_ID = Attendance.Course_ID where student_ID = 