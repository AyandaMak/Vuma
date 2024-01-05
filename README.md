# VumaCam Assessment Repo
This is the repository for the VumaCam technical assessment. The solution contains 3 projects. VumaCamAssessment, CalcAreaTest and Library. The 3 projects were used to answer the questions below. The projects which contain the answers will be outlined below. 

# Quesstion 1: SOLID principles 
VumaCamAssessment project contains the classes Circle, Triangle and Square. Single Responsibility Principle (SRP) and the Open / Closed principles (OCP) were applied by introducing an interface IShape to implement our OCP by overriding CalculateArea() function for each shape. SRP is utilized by the each class containing necessary attributes for their shape. 

# Quesstion 2: Testing
CalcAreaTest unit test project contains the unit test for the different areas for the shapes. 

# Quesstion 3: Documentation
VumaCamAssessment project contains all the comments in the classes and methods in Question 1. 

# Quesstion 4: Database normalization
The Library project in the Model folder contains the model classes for the database design. This is a code first approach. 

# Quesstion 5: Source Control Management
Assuming the project contains two remote branches main and develop. Before working on the features on local branches, both developers will need to ensure the branches are created on the same remote develop branch version. This will be achieved by running a fetch and pull command on the local develop branch from the remote develop branch before creating the local feature branches. This is ensure that both developers are working on the latest version of the same branch. As a developer I would then create a local branch based on latest remote develop give it a relevant name in this case we will call it Feature1. My colleague would also create a local branch based on the latest remote develop branch and assume the name as Feature2.  We will now assume that Feature2 branch is completed first a push command is done to the remote repository and a pull request is created to merge with develop with the relevant changes in the pull request description. We will also assume that pull request is approved whilst Feature1 is still in progress. Some degree of collaboration and communication will be done with the colleague on the latest changes made and review the pull request. I could then stash changes made for Feature1 and pull the latest changes to the local develop branch which is merged with Feature2 branch changes. I would then merge develop branch with local Feature1 branch and apply the stashed changes and resolve any conflicts if they occurred and push the changes for Feature1 branch to the remote repository with and submit a pull request which contains the changes of Feature2. 
# Quesstion 6: Seeking Assistance

Step 1: Trace back changes made and see where the cause of the issue may lie.
Step 2: Check online sources such as stackoverflow or blogs for similar or related issues.
Step 3: If online sources cannot resolve my issue referring to colleagues who might have knowledge of the issue
Step 4: When debugging with a colleague I would explain and describe all steps I have already performed and share information I have received from online resources to assist in debugging the issue in a shorter period of time. Reason for this is explore options I have not already considered or attempted to resolved the issue and redirect the approach. 
