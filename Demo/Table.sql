CREATE TABLE CUTE_ANIMALS(
	ANIMAL_TYPE NVARCHAR(20) NOT NULL,
	ANIMAL_NAME NVARCHAR(20) NOT NULL,
	PHOTO NVARCHAR(MAX) NOT NULL,
	CUTENESS_LEVEL INT
)

INSERT INTO CUTE_ANIMALS VALUES
	('dog', 'Hercules', 'https://pbs.twimg.com/media/ERvur68VUAI8qyi?format=jpg&name=medium', 14),
	('dog', 'Miller', 'https://pbs.twimg.com/media/ERovYQiUYAA3rBD?format=jpg&name=medium', 12),
	('dog', 'Winnie', 'https://pbs.twimg.com/media/ERjoSOXUYAA11dD?format=jpg&name=medium', 12),
	('dog', 'Skye', 'https://pbs.twimg.com/media/ERU2Z2xU8AYRimj?format=jpg&name=medium', 13),
	('dog', 'Rusty', 'https://pbs.twimg.com/media/ERP8JE7XYAwHygA?format=jpg&name=medium', 15),
	('dog', 'Kicker', 'https://pbs.twimg.com/media/ERJ63NqVAAE-YQs?format=jpg&name=medium', 12),
	('dog', 'Wally', 'https://pbs.twimg.com/media/EQ15CWRUYAAAaxw?format=jpg&name=medium', 13),
	('dog', 'Theo', 'https://pbs.twimg.com/media/EQns_v_UcAAT6gY?format=jpg&name=medium', 13),
	('dog', 'Pancake', 'https://pbs.twimg.com/media/EP-VMYgVAAAOAkf?format=jpg&name=medium', 13),
	('dog', 'Oatie', 'https://pbs.twimg.com/media/EN4dZxbU0AA14GN?format=jpg&name=medium', 12),
	('dog', 'Maya', 'https://pbs.twimg.com/media/D1JBqpTXgAE4TMF?format=jpg&name=medium', 16),
	('cat', 'Tardar Sauce', 'https://pbs.twimg.com/media/ERKzABMUwAAI6-i?format=jpg&name=medium', 10),
	('cat', 'Miggy', 'https://pbs.twimg.com/media/EQwd2tvX0AARs_R?format=jpg&name=medium', 12),
	('cat', 'Luna', 'https://pbs.twimg.com/media/ESAwqKAXkAEYRmU?format=jpg&name=medium', 11),
	('cat', 'Brutus', 'https://pbs.twimg.com/media/ESBME9EWAAEUuYr?format=jpg&name=medium', 11),
	('cat', 'Artie', 'https://pbs.twimg.com/media/ESAwoDfWAAAuTjT?format=jpg&name=medium', 15),
	('cat', 'Ophelia', 'https://pbs.twimg.com/media/ESAwm-WWAAEepcL?format=jpg&name=medium', 12),
	('cat', 'Ahm', 'https://pbs.twimg.com/media/ER-ZFfsXYAA4AEG?format=jpg&name=900x900', 14),
	('hedgehog', 'Baby', 'https://pbs.twimg.com/media/ESAzJ4dWoAEbrgI?format=jpg&name=900x900', 15),
	('hedgehog', 'Lionel', 'https://pbs.twimg.com/media/D9h4phWWkAIzI2B?format=jpg&name=medium', 14),
	('hedgehog', 'Azuki', 'https://pbs.twimg.com/media/ERgVi7HWAAIoJ7f?format=jpg&name=medium', 13),
	('hedgehog', 'Pokee', 'https://pbs.twimg.com/media/EKBJgtsUUAIZyhR?format=jpg&name=900x900', 15),
	('hedgehog', 'Darcy', 'https://pbs.twimg.com/media/CgzxJZOXEAA_yAn?format=jpg&name=medium', 12);