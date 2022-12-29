## Server requirements

#### APIS

1 **/register** endpoint for creating new users
- user registers with email and password

2 **/login** endpoint for logging (with JWT)
- user logs in with email and password

3 **/status** endpoint for creating and retrieving status
- GET: Get latest 10 statuses of all users except logged in user
- POST: Create new status for user

4 **/story** endpoint for creating and retrieving stories
- GET: Get latest 10 stories of all users except logged in user
- POST: Create new story for user

## System assumptions
- All users are friends by default
- The system needs no other services (e.g. messenger, poke, react)