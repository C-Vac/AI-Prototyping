INSERT INTO concept (
    id, 
    name, 
    category)
VALUES (
    id:int,
    'name:varchar',
    'category:varchar'
  );
INSERT INTO note (
    id,
    title,
    timestamp,
    owner_id,
    note_text,
    file_path,
    related_skills,
    related_concepts
  )
VALUES (
    id:int,
    'title:varchar',
    'timestamp:datetime',
    owner_id:int,
    'note_text:text',
    'file_path:varchar',
    'related_skills:json',
    'related_concepts:json'
  );
INSERT INTO person (id, name, contact_info)
VALUES (
    id:int,
    'name:varchar',
    'contact_info:text'
  );
INSERT INTO project (id, name, description, owner_id, category)
VALUES (
    id:int,
    'name:varchar',
    'description:text',
    owner_id:int,
    'category:enum'
  );
INSERT INTO skill (id, name, category)
VALUES (
    id:int,
    'name:varchar',
    'category:varchar'
  );
INSERT INTO task (
    id,
    name,
    description,
    added_timestamp,
    completed_timestamp,
    project_id,
    priority
  )
VALUES (
    id:int,
    'name:varchar',
    'description:text',
    'added_timestamp:datetime',
    'completed_timestamp:datetime',
    project_id:int,
    'priority:enum'
  );
INSERT INTO user (id, username, person_id)
VALUES (
    id:int,
    'username:varchar',
    person_id:int
  );
