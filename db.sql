CREATE DATABASE plannerdb;

USE plannerdb;

CREATE TABLE tasks(
    TaskDate date,
    TaskHour time,
    TaskTitle varchar(100),
    TaskNotes varchar(500),
	TaskIdeas varchar(500),
	TaskToDo varchar(500),
	PRIMARY KEY(TaskDate, TaskHour)
);

INSERT INTO tasks
	(TaskDate, TaskHour, TaskTitle, TaskNotes, TaskIdeas, TaskToDo, TaskDone)
VALUES 
	('2021-05-29', '23:00', '1_TaskTitle', '1_TaskNotes', '1_TaskIdeas', '1_TaskToDo', 0 ),
	('2021-05-30', '13:00', '2_TaskTitle', '2_TaskNotes', '2_TaskIdeas', '2_TaskToDo', 0 ),
    ('2021-05-30', '17:00', '3_TaskTitle', '3_TaskNotes', '3_TaskIdeas', '3_TaskToDo', 0 );